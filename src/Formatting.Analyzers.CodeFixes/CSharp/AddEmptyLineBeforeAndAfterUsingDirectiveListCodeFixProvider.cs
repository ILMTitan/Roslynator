﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Composition;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslynator.CSharp;
using Roslynator.Formatting.CSharp;

namespace Roslynator.Formatting.CodeFixes.CSharp
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(AddEmptyLineBeforeAndAfterUsingDirectiveListCodeFixProvider))]
    [Shared]
    public class AddEmptyLineBeforeAndAfterUsingDirectiveListCodeFixProvider : BaseCodeFixProvider
    {
        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(DiagnosticIdentifiers.AddEmptyLineBeforeAndAfterUsingDirectiveList); }
        }

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            SyntaxNode root = await context.GetSyntaxRootAsync().ConfigureAwait(false);

            if (!TryFindFirstAncestorOrSelf(
                root,
                context.Span,
                out SyntaxNode node,
                findInsideTrivia: true,
                predicate: f => f.IsKind(SyntaxKind.UsingDirective, SyntaxKind.RegionDirectiveTrivia, SyntaxKind.EndRegionDirectiveTrivia)))
            {
                return;
            }

            Document document = context.Document;
            Diagnostic diagnostic = context.Diagnostics[0];

            switch (node)
            {
                case UsingDirectiveSyntax usingDirective:
                    {
                        if (context.Span.Start == usingDirective.SpanStart)
                        {
                            CodeAction codeAction = CodeAction.Create(
                                "Add empty line",
                                ct => AddEmptyLineBeforeUsingDirectiveAsync(document, usingDirective, ct),
                                GetEquivalenceKey(diagnostic));

                            context.RegisterCodeFix(codeAction, diagnostic);
                        }
                        else
                        {
                            CodeAction codeAction = CodeAction.Create(
                                "Add empty line",
                                ct => AddEmptyLineAfterUsingDirectiveAsync(document, usingDirective, ct),
                                GetEquivalenceKey(diagnostic));

                            context.RegisterCodeFix(codeAction, diagnostic);
                        }

                        break;
                    }
                case RegionDirectiveTriviaSyntax regionDirective:
                    {
                        CodeAction codeAction = CodeAction.Create(
                            "Add empty line",
                            ct => CodeFixHelpers.AddEmptyLineBeforeDirectiveAsync(document, regionDirective, ct),
                            GetEquivalenceKey(diagnostic));

                        context.RegisterCodeFix(codeAction, diagnostic);
                        break;
                    }
                case EndRegionDirectiveTriviaSyntax endRegionDirective:
                    {
                        CodeAction codeAction = CodeAction.Create(
                            "Add empty line",
                            ct => CodeFixHelpers.AddEmptyLineAfterDirectiveAsync(document, endRegionDirective, ct),
                            GetEquivalenceKey(diagnostic));

                        context.RegisterCodeFix(codeAction, diagnostic);
                        break;
                    }
            }
        }

        private static Task<Document> AddEmptyLineBeforeUsingDirectiveAsync(
            Document document,
            UsingDirectiveSyntax usingDirective,
            CancellationToken cancellationToken)
        {
            SyntaxTriviaList leadingTrivia = usingDirective.GetLeadingTrivia();

            int index = leadingTrivia.Count;

            if (index > 0
            && leadingTrivia.Last().IsWhitespaceTrivia())
            {
                index--;
            }

            SyntaxTriviaList newLeadingTrivia = leadingTrivia.Insert(index, SyntaxTriviaAnalysis.GetEndOfLine(usingDirective));

            UsingDirectiveSyntax newUsingDirective = usingDirective.WithLeadingTrivia(newLeadingTrivia);

            return document.ReplaceNodeAsync(usingDirective, newUsingDirective, cancellationToken);
        }

        private static Task<Document> AddEmptyLineAfterUsingDirectiveAsync(
            Document document,
            UsingDirectiveSyntax usingDirective,
            CancellationToken cancellationToken)
        {
            UsingDirectiveSyntax newUsingDirective = usingDirective.AppendEndOfLineToTrailingTrivia();

            return document.ReplaceNodeAsync(usingDirective, newUsingDirective, cancellationToken);
        }
    }
}
