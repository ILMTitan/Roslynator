﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Pihrtsoft.CodeAnalysis.CSharp.Refactorings
{
    internal static class InitializerExpressionRefactoring
    {
        public static async Task ComputeRefactoringsAsync(RefactoringContext context, InitializerExpressionSyntax initializer)
        {
            if (initializer.IsKind(SyntaxKind.ComplexElementInitializerExpression)
                && initializer.Parent?.IsKind(SyntaxKind.CollectionInitializerExpression) == true)
            {
                initializer = (InitializerExpressionSyntax)initializer.Parent;
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.FormatInitializer)
                && initializer.Expressions.Count > 0
                && !initializer.IsKind(SyntaxKind.ComplexElementInitializerExpression)
                && initializer.Parent?.IsKind(
                    SyntaxKind.ArrayCreationExpression,
                    SyntaxKind.ImplicitArrayCreationExpression,
                    SyntaxKind.ObjectCreationExpression,
                    SyntaxKind.CollectionInitializerExpression) == true)
            {
                if (initializer.IsSingleLine(includeExteriorTrivia: false))
                {
                    context.RegisterRefactoring(
                        "Format initializer on multiple lines",
                        cancellationToken => FormatInitializerOnMultipleLinesRefactoring.RefactorAsync(
                            context.Document,
                            initializer,
                            cancellationToken));
                }
                else if (initializer.Expressions.All(expression => expression.IsSingleLine()))
                {
                    context.RegisterRefactoring(
                        "Format initializer on a single line",
                        cancellationToken => FormatInitializerOnSingleLineRefactoring.RefactorAsync(
                            context.Document,
                            initializer,
                            cancellationToken));
                }
            }

            await ExpandInitializerRefactoring.ComputeRefactoringsAsync(context, initializer).ConfigureAwait(false);
        }
    }
}
