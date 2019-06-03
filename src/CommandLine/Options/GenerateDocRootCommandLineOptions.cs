// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using CommandLine;

namespace Roslynator.CommandLine
{
    [Verb("generate-doc-root", HelpText = "Generates root documentation file from specified assemblies.")]
    public class GenerateDocRootCommandLineOptions : AbstractGenerateDocCommandLineOptions
    {
        [Option(longName: "include-containing-namespace",
            HelpText = "Indicates whether a containing namespace should be included when displaying type name.")]
        public bool IncludeContainingNamespace { get; set; }

        [Option(longName: ParameterNames.IncludeSystemNamespace,
            HelpText = "Indicates whether namespace should be included when a type is directly contained in namespace 'System'.")]
        public bool IncludeSystemNamespace { get; set; }

        [Option(longName: "ignored-parts",
            HelpText = "Defines parts of a root documentation that should be excluded. Allowed values are content, namespaces, classes, static-classes, structs, interfaces, enums, delegates and other",
            MetaValue = "<IGNORED_PARTS>")]
        public IEnumerable<string> IgnoredParts { get; set; }

        [Option(longName: ParameterNames.RootDirectoryUrl,
            HelpText = "Defines a relative url to the documentation root directory.",
            MetaValue = "<ROOT_DIRECTORY_URL>")]
        public string RootDirectoryUrl { get; set; }
    }
}
