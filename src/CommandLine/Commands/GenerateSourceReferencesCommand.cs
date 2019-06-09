// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.CodeAnalysis;
using Roslynator.Documentation;
using Roslynator.FindSymbols;
using static Roslynator.Logger;
using System.Collections.Immutable;

namespace Roslynator.CommandLine
{
    internal class GenerateSourceReferencesCommand : MSBuildWorkspaceCommand
    {
        public GenerateSourceReferencesCommand(
            GenerateSourceReferencesCommandLineOptions options,
            DocumentationDepth depth,
            Visibility visibility,
            in ProjectFilter projectFilter) : base(projectFilter)
        {
            Options = options;
            Depth = depth;
            Visibility = visibility;
        }

        public GenerateSourceReferencesCommandLineOptions Options { get; }

        public DocumentationDepth Depth { get; }

        public Visibility Visibility { get; }

        public override async Task<CommandResult> ExecuteAsync(ProjectOrSolution projectOrSolution, CancellationToken cancellationToken = default)
        {
            AssemblyResolver.Register();

            var filter = new SymbolFilterOptions(Visibility.ToVisibilityFilter());

            WriteLine($"Write source references to '{Options.Output}'", ConsoleColor.DarkGray, Verbosity.Diagnostic);

            using (XmlWriter writer = XmlWriter.Create(Options.Output, new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("source");
                writer.WriteStartElement("repository");

                writer.WriteAttributeString("type", Options.RepositoryType);
                writer.WriteAttributeString("url", Options.RepositoryUrl);
                writer.WriteAttributeString("version", Options.Version);
                writer.WriteAttributeString("branch", Options.Branch);
                writer.WriteAttributeString("commit", Options.Commit);
                writer.WriteStartElement("members");

                foreach (Project project in FilterProjects(projectOrSolution))
                {
                    Compilation compilation = await project.GetCompilationAsync(cancellationToken);

                    IAssemblySymbol assembly = compilation.Assembly;

                    foreach (INamedTypeSymbol type in assembly.GetTypes(symbol => filter.IsMatch(symbol)))
                    {
                        WriteSymbol(writer, type, cancellationToken);

                        foreach (ISymbol member in type
                            .GetMembers()
                            .Where(symbol => !symbol.IsKind(SymbolKind.NamedType) && filter.IsMatch(symbol)))
                        {
                            WriteSymbol(writer, member, cancellationToken);
                        }
                    }
                }

                writer.WriteEndDocument();
            }

            WriteLine($"Source references successfully saved to '{Options.Output}'.", Verbosity.Minimal);

            return CommandResult.Success;
        }

        private void WriteSymbol(XmlWriter writer, ISymbol symbol, CancellationToken cancellationToken)
        {
            writer.WriteStartElement("member");
            writer.WriteAttributeString("name", symbol.GetDocumentationCommentId());

            ImmutableArray<SyntaxReference> syntaxReferences = symbol.DeclaringSyntaxReferences;

            if (syntaxReferences.Any())
            {
                writer.WriteStartElement("locations");

                foreach (SyntaxReference syntaxReference in syntaxReferences)
                {
                    SyntaxTree tree = syntaxReference.SyntaxTree;

                    string path = tree.FilePath;

                    if (path.StartsWith(Options.RootPath, StringComparison.OrdinalIgnoreCase))
                    {
                        path = path.Remove(0, Options.RootPath.Length);
                    }

                    Debug.Assert(path != null, symbol.ToDisplayString());

                    int line = tree.GetLineSpan(syntaxReference.Span, cancellationToken).StartLine();

                    writer.WriteStartElement("location");
                    writer.WriteAttributeString("path", path);
                    writer.WriteAttributeString("line", line.ToString(CultureInfo.InvariantCulture));
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
