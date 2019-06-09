// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;

namespace Roslynator
{
    public sealed class SourceReferenceProvider
    {
        private readonly ImmutableDictionary<string, ImmutableArray<SymbolSourceReference>> _map;

        private SourceReferenceProvider(ImmutableDictionary<string, ImmutableArray<SymbolSourceReference>> map)
        {
            _map = map;
        }

        public ImmutableArray<SourceReference> GetSourceReferences(ISymbol symbol)
        {
            string id = symbol.GetDocumentationCommentId();

            Debug.Assert(!string.IsNullOrEmpty(id), symbol.ToDisplayString());

            if (_map.TryGetValue(id, out ImmutableArray<SymbolSourceReference> references))
            {
                return ImmutableArray.CreateRange(references, f => new SourceReference(f.Repository.Version, f.GetUrl()));
            }

            return ImmutableArray<SourceReference>.Empty;
        }

        public static SourceReferenceProvider Load(IEnumerable<string> paths)
        {
            ImmutableDictionary<string, ImmutableArray<SymbolSourceReference>.Builder>.Builder dic = ImmutableDictionary.CreateBuilder<string, ImmutableArray<SymbolSourceReference>.Builder>();

            foreach (string uri in paths)
            {
                XDocument doc = XDocument.Load(uri);

                foreach (XElement repositoryElement in doc.Root.Elements("repository"))
                {
                    string type = repositoryElement.Attribute("type").Value;
                    string url = repositoryElement.Attribute("url").Value;
                    string version = repositoryElement.Attribute("version").Value;
                    string branch = repositoryElement.Attribute("branch").Value;
                    string commit = repositoryElement.Attribute("commit").Value;

                    var repository = new RepositoryReference(name: type, url: url, version: version, branch: branch, commit: commit);

                    XElement membersElements = repositoryElement.Element("members");

                    if (membersElements != null)
                    {
                        foreach (XElement memberElement in membersElements.Elements("member"))
                        {
                            Debug.WriteLine(memberElement);

                            string name = memberElement.Attribute("name").Value;

                            XElement locationElement = memberElement.Element("locations")?.Element("location");

                            string path = null;
                            int line = -1;

                            if (locationElement != null)
                            {
                                path = locationElement.Attribute("path").Value;
                                line = int.Parse(locationElement.Attribute("line").Value);
                            }

                            if (!dic.TryGetValue(name, out ImmutableArray<SymbolSourceReference>.Builder builder))
                            {
                                builder = ImmutableArray.CreateBuilder<SymbolSourceReference>();
                                dic[name] = builder;
                            }

                            builder.Add(new SymbolSourceReference(repository, path, line));
                        }
                    }
                }
            }

            ImmutableDictionary<string, ImmutableArray<SymbolSourceReference>> map = dic.ToImmutableDictionary(f => f.Key, f => f.Value.ToImmutableArray());

            return new SourceReferenceProvider(map);
        }

        private readonly struct RepositoryReference
        {
            public RepositoryReference(string name, string url, string version, string branch, string commit)
            {
                Name = name;
                Url = url;
                Version = version;
                Branch = branch;
                Commit = commit;
            }

            public string Name { get; }

            public string Url { get; }

            public string Version { get; }

            public string Branch { get; }

            public string Commit { get; }

            public string GetUrl(string url)
            {
                return $"{Url}/{Branch}/tree/{Commit}{url}";
            }
        }

        private readonly struct SymbolSourceReference
        {
            public SymbolSourceReference(RepositoryReference repository, string path, int line)
            {
                Repository = repository;
                Path = path;
                Line = line;
            }

            public RepositoryReference Repository { get; }

            public string Path { get; }

            public int Line { get; }

            public string GetUrl()
            {
                return (Path != null) ? Repository.GetUrl(Path) : null;
            }
        }
    }
}
