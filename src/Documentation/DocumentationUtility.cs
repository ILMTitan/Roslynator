// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text;
using Microsoft.CodeAnalysis;
using Roslynator.Text;

namespace Roslynator.Documentation
{
    internal static class DocumentationUtility
    {
        public static string CreateLocalLink(ISymbol symbol)
        {
            StringBuilder sb = StringBuilderCache.GetInstance();

            int cnc = 0;

            INamespaceSymbol cn = symbol.ContainingNamespace;

            while (cn?.IsGlobalNamespace == false)
            {
                cn = cn.ContainingNamespace;
                cnc++;
            }

            while (cnc > 0)
            {
                sb.Append(GetContainingNamespace(cnc).Name);
                sb.Append("_");
                cnc--;
            }

            INamedTypeSymbol ct = symbol.ContainingType;

            int ctc = 0;

            while (ct != null)
            {
                ct = ct.ContainingType;
                ctc++;
            }

            while (ctc > 0)
            {
                AppendType(GetContainingType(ctc));
                sb.Append("_");
                ctc--;
            }

            if (symbol.IsKind(SymbolKind.NamedType))
            {
                AppendType((INamedTypeSymbol)symbol);
            }
            else
            {
                sb.Append(symbol.Name);
            }

            return StringBuilderCache.GetStringAndFree(sb);

            INamespaceSymbol GetContainingNamespace(int count)
            {
                INamespaceSymbol n = symbol.ContainingNamespace;

                while (count > 1)
                {
                    n = n.ContainingNamespace;
                    count--;
                }

                return n;
            }

            INamedTypeSymbol GetContainingType(int count)
            {
                INamedTypeSymbol t = symbol.ContainingType;

                while (count > 1)
                {
                    t = t.ContainingType;
                    count--;
                }

                return t;
            }

            void AppendType(INamedTypeSymbol typeSymbol)
            {
                sb.Append(typeSymbol.Name);

                int arity = typeSymbol.Arity;

                if (arity > 0)
                {
                    sb.Append("_");
                    sb.Append(arity.ToString());
                }
            }
        }
    }
}
