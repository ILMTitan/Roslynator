// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Roslynator.Documentation
{
    [Flags]
    public enum IncludeContainingNamespaceFilter
    {
        None = 0,
        TypeList = 1,
        ClassHierarchy = 2,
        ContainingType = 4,
        Parameter = 8,
        ReturnType = 16,
        BaseType = 32,
        Attribute = 64,
        DerivedType = 128,
        ImplementedInterface = 256,
        ImplementedMember = 512,
        Exception = 1024,
        SeeAlso = 2048,
        All = int.MaxValue
    }
}
