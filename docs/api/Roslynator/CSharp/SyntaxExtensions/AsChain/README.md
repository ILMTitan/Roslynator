# SyntaxExtensions\.AsChain\(BinaryExpressionSyntax, TextSpan?\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns [ExpressionChain](../../ExpressionChain/README.md) that enables to enumerate expressions of a binary expression\.

```csharp
public static Roslynator.CSharp.ExpressionChain AsChain(this Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax binaryExpression, Microsoft.CodeAnalysis.Text.TextSpan? span = null)
```

### Parameters

**binaryExpression** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[BinaryExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.binaryexpressionsyntax)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)?

### Returns

Roslynator\.CSharp\.[ExpressionChain](../../ExpressionChain/README.md)

