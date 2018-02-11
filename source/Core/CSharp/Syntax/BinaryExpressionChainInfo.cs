﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Roslynator.CSharp.Syntax.SyntaxInfoHelpers;

namespace Roslynator.CSharp.Syntax
{
    //TODO: ireadonlylist
    internal struct BinaryExpressionChainInfo : IEquatable<BinaryExpressionChainInfo>
    {
        private BinaryExpressionChainInfo(
            BinaryExpressionSyntax binaryExpression,
            SyntaxKind kind,
            IEnumerable<ExpressionSyntax> expressions)
        {
            BinaryExpression = binaryExpression;
            Kind = kind;
            Expressions = ImmutableArray.CreateRange(expressions);
        }

        private static BinaryExpressionChainInfo Default { get; } = new BinaryExpressionChainInfo();

        public BinaryExpressionSyntax BinaryExpression { get; }

        public SyntaxKind Kind { get; }

        public ImmutableArray<ExpressionSyntax> Expressions { get; }

        public bool Success
        {
            get { return BinaryExpression != null; }
        }

        internal static BinaryExpressionChainInfo Create(
            SyntaxNode node,
            bool walkDownParentheses = true)
        {
            return Create(Walk(node, walkDownParentheses) as BinaryExpressionSyntax);
        }

        internal static BinaryExpressionChainInfo Create(BinaryExpressionSyntax binaryExpression)
        {
            if (binaryExpression == null)
                return Default;

            return CreateCore(binaryExpression, binaryExpression.Kind());
        }

        private static BinaryExpressionChainInfo CreateCore(BinaryExpressionSyntax binaryExpression, SyntaxKind kind)
        {
            List<ExpressionSyntax> expressions = GetExpressions(binaryExpression, kind);

            if (expressions == null)
                return Default;

            expressions.Reverse();

            return new BinaryExpressionChainInfo(binaryExpression, kind, expressions);
        }

        private static List<ExpressionSyntax> GetExpressions(
            BinaryExpressionSyntax binaryExpression,
            SyntaxKind kind)
        {
            List<ExpressionSyntax> expressions = null;
            bool success = true;

            while (success)
            {
                success = false;

                if (binaryExpression.Kind() == kind)
                {
                    ExpressionSyntax right = binaryExpression.Right;

                    if (right?.IsMissing == false)
                    {
                        (expressions ?? (expressions = new List<ExpressionSyntax>())).Add(right);

                        ExpressionSyntax left = binaryExpression.Left;

                        if (left?.IsMissing == false)
                        {
                            if (left.Kind() == kind)
                            {
                                binaryExpression = (BinaryExpressionSyntax)left;
                                success = true;
                            }
                            else
                            {
                                expressions.Add(left);
                                return expressions;
                            }
                        }
                    }
                }
            }

            return null;
        }

        public override string ToString()
        {
            return BinaryExpression?.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is BinaryExpressionChainInfo other && Equals(other);
        }

        public bool Equals(BinaryExpressionChainInfo other)
        {
            return EqualityComparer<BinaryExpressionSyntax>.Default.Equals(BinaryExpression, other.BinaryExpression);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<BinaryExpressionSyntax>.Default.GetHashCode(BinaryExpression);
        }

        public static bool operator ==(BinaryExpressionChainInfo info1, BinaryExpressionChainInfo info2)
        {
            return info1.Equals(info2);
        }

        public static bool operator !=(BinaryExpressionChainInfo info1, BinaryExpressionChainInfo info2)
        {
            return !(info1 == info2);
        }
    }
}
