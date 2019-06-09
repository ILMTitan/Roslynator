﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator
{
    public readonly struct SourceReference
    {
        public SourceReference(string version, string url)
        {
            Version = version;
            Url = url;
        }

        public string Version { get; }

        public string Url { get; }
    }
}
