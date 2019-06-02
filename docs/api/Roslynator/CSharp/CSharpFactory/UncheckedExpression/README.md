# CSharpFactory\.UncheckedExpression Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[CSharpFactory](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [UncheckedExpression(ExpressionSyntax)](#Roslynator_CSharp_CSharpFactory_UncheckedExpression_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_) | |
| [UncheckedExpression(SyntaxToken, ExpressionSyntax, SyntaxToken)](#Roslynator_CSharp_CSharpFactory_UncheckedExpression_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_Microsoft_CodeAnalysis_SyntaxToken_) | |

## UncheckedExpression\(ExpressionSyntax\) <a name="Roslynator_CSharp_CSharpFactory_UncheckedExpression_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_"></a>

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax UncheckedExpression(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax expression)
```

### Parameters

**expression** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[CheckedExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.checkedexpressionsyntax)

## UncheckedExpression\(SyntaxToken, ExpressionSyntax, SyntaxToken\) <a name="Roslynator_CSharp_CSharpFactory_UncheckedExpression_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_Microsoft_CodeAnalysis_SyntaxToken_"></a>

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax UncheckedExpression(Microsoft.CodeAnalysis.SyntaxToken openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax expression, Microsoft.CodeAnalysis.SyntaxToken closeParenToken)
```

### Parameters

**openParenToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**expression** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

**closeParenToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[CheckedExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.checkedexpressionsyntax)

