// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    internal sealed class SymbolComparer : IComparer<ISymbol>
    {
        private SymbolComparer(SymbolDisplayFormat format, SymbolDefinitionSortOptions options, SymbolDisplayAdditionalMemberOptions additionalOptions)
        {
            Format = format;
            Options = options;
            AdditionalOptions = additionalOptions;
        }

        public static SymbolComparer Create(
            bool systemNamespaceFirst = true,
            bool includeNamespaces = true,
            bool includeContainingTypes = true,
            SymbolDisplayAdditionalMemberOptions additionalOptions = SymbolDisplayAdditionalMemberOptions.None)
        {
            var options = SymbolDefinitionSortOptions.None;

            if (systemNamespaceFirst)
                options |= SymbolDefinitionSortOptions.SystemFirst;

            if (!includeNamespaces)
                options |= SymbolDefinitionSortOptions.OmitContainingNamespace;

            if (!includeContainingTypes)
                options |= SymbolDefinitionSortOptions.OmitContainingType;

            SymbolDisplayFormat format = TypeSymbolDisplayFormats.GetFormat(
                includeNamespaces: false,
                includeContainingTypes: includeContainingTypes);

            return new SymbolComparer(format, options, additionalOptions);
        }

        public SymbolDisplayFormat Format { get; }

        public SymbolDefinitionSortOptions Options { get; }

        public SymbolDisplayAdditionalMemberOptions AdditionalOptions { get; }

        public int Compare(ISymbol x, ISymbol y)
        {
            if (object.ReferenceEquals(x, y))
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            int diff = 0;

            if ((Options & SymbolDefinitionSortOptions.OmitContainingNamespace) == 0)
            {
                if ((Options & SymbolDefinitionSortOptions.SystemFirst) != 0)
                {
                    diff = SymbolDefinitionComparer.SystemFirst.CompareContainingNamespace(x, y);
                }
                else
                {
                    diff = SymbolDefinitionComparer.Default.CompareContainingNamespace(x, y);
                }

                if (diff != 0)
                    return diff;
            }

            return string.Compare(x.ToDisplayString(Format, AdditionalOptions), y.ToDisplayString(Format, AdditionalOptions), StringComparison.InvariantCulture);
        }
    }
}
