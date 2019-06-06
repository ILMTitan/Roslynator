// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.CodeAnalysis;

namespace Roslynator
{
    internal static class TypeSymbolDisplayFormats
    {
        public static SymbolDisplayFormat Name { get; } = new SymbolDisplayFormat(
            typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameOnly,
            genericsOptions: SymbolDisplayGenericsOptions.None,
            memberOptions: SymbolDisplayMemberOptions.IncludeContainingType);

        public static SymbolDisplayFormat NameAndTypeParameters { get; } = new SymbolDisplayFormat(
            typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameOnly,
            genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters,
            memberOptions: SymbolDisplayMemberOptions.IncludeContainingType);

        public static SymbolDisplayFormat NameAndContainingTypes { get; } = new SymbolDisplayFormat(
            typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypes,
            genericsOptions: SymbolDisplayGenericsOptions.None,
            memberOptions: SymbolDisplayMemberOptions.IncludeContainingType);

        public static SymbolDisplayFormat NameAndContainingTypesAndTypeParameters { get; } = new SymbolDisplayFormat(
            typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypes,
            genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters,
            memberOptions: SymbolDisplayMemberOptions.IncludeContainingType);

        public static SymbolDisplayFormat NameAndContainingTypesAndNamespaces { get; } = new SymbolDisplayFormat(
            globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining,
            typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces,
            genericsOptions: SymbolDisplayGenericsOptions.None,
            memberOptions: SymbolDisplayMemberOptions.IncludeContainingType);

        public static SymbolDisplayFormat NameAndContainingTypesAndNamespacesAndTypeParameters { get; } = new SymbolDisplayFormat(
            globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining,
            typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces,
            genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters,
            memberOptions: SymbolDisplayMemberOptions.IncludeContainingType);

        public static SymbolDisplayFormat NameAndContainingTypesAndNamespacesAndGlobalNamespaceAndTypeParameters { get; } = new SymbolDisplayFormat(
            globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Included,
            typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces,
            genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters,
            memberOptions: SymbolDisplayMemberOptions.IncludeContainingType);

        public static SymbolDisplayFormat GetFormat(
            bool includeNamespaces = true,
            bool includeContainingTypes = true,
            bool includeTypeParameters = true)
        {
            if (includeNamespaces)
            {
                if (includeContainingTypes)
                {
                    return (includeTypeParameters)
                        ? NameAndContainingTypesAndNamespacesAndTypeParameters
                        : NameAndContainingTypesAndNamespaces;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            else if (includeContainingTypes)
            {
                return (includeTypeParameters)
                    ? NameAndContainingTypesAndTypeParameters
                    : NameAndContainingTypes;
            }
            else
            {
                return (includeTypeParameters)
                    ? NameAndTypeParameters
                    : Name;
            }
        }
    }
}
