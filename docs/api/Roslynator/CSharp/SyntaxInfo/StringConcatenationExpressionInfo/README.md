# SyntaxInfo\.StringConcatenationExpressionInfo Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [StringConcatenationExpressionInfo(BinaryExpressionSyntax, SemanticModel, CancellationToken)](#Roslynator_CSharp_SyntaxInfo_StringConcatenationExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_BinaryExpressionSyntax_Microsoft_CodeAnalysis_SemanticModel_System_Threading_CancellationToken_) | Creates a new [StringConcatenationExpressionInfo](../../Syntax/StringConcatenationExpressionInfo/README.md) from the specified node\. |
| [StringConcatenationExpressionInfo(ExpressionChain, SemanticModel, CancellationToken)](#Roslynator_CSharp_SyntaxInfo_StringConcatenationExpressionInfo_Roslynator_CSharp_ExpressionChain__Microsoft_CodeAnalysis_SemanticModel_System_Threading_CancellationToken_) | Creates a new [StringConcatenationExpressionInfo](../../Syntax/StringConcatenationExpressionInfo/README.md) from the specified expression chain\. |
| [StringConcatenationExpressionInfo(SyntaxNode, SemanticModel, Boolean, CancellationToken)](#Roslynator_CSharp_SyntaxInfo_StringConcatenationExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_SemanticModel_System_Boolean_System_Threading_CancellationToken_) | Creates a new [StringConcatenationExpressionInfo](../../Syntax/StringConcatenationExpressionInfo/README.md) from the specified node\. |

## StringConcatenationExpressionInfo\(BinaryExpressionSyntax, SemanticModel, CancellationToken\) <a name="Roslynator_CSharp_SyntaxInfo_StringConcatenationExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_BinaryExpressionSyntax_Microsoft_CodeAnalysis_SemanticModel_System_Threading_CancellationToken_"></a>

### Summary

Creates a new [StringConcatenationExpressionInfo](../../Syntax/StringConcatenationExpressionInfo/README.md) from the specified node\.

```csharp
public static Roslynator.CSharp.Syntax.StringConcatenationExpressionInfo StringConcatenationExpressionInfo(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax binaryExpression, Microsoft.CodeAnalysis.SemanticModel semanticModel, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**binaryExpression** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[BinaryExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.binaryexpressionsyntax)

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Roslynator\.CSharp\.Syntax\.[StringConcatenationExpressionInfo](../../Syntax/StringConcatenationExpressionInfo/README.md)

## StringConcatenationExpressionInfo\(ExpressionChain, SemanticModel, CancellationToken\) <a name="Roslynator_CSharp_SyntaxInfo_StringConcatenationExpressionInfo_Roslynator_CSharp_ExpressionChain__Microsoft_CodeAnalysis_SemanticModel_System_Threading_CancellationToken_"></a>

### Summary

Creates a new [StringConcatenationExpressionInfo](../../Syntax/StringConcatenationExpressionInfo/README.md) from the specified expression chain\.

```csharp
public static Roslynator.CSharp.Syntax.StringConcatenationExpressionInfo StringConcatenationExpressionInfo(in Roslynator.CSharp.ExpressionChain expressionChain, Microsoft.CodeAnalysis.SemanticModel semanticModel, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**expressionChain** &emsp; Roslynator\.CSharp\.[ExpressionChain](../../ExpressionChain/README.md)

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Roslynator\.CSharp\.Syntax\.[StringConcatenationExpressionInfo](../../Syntax/StringConcatenationExpressionInfo/README.md)

## StringConcatenationExpressionInfo\(SyntaxNode, SemanticModel, Boolean, CancellationToken\) <a name="Roslynator_CSharp_SyntaxInfo_StringConcatenationExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_SemanticModel_System_Boolean_System_Threading_CancellationToken_"></a>

### Summary

Creates a new [StringConcatenationExpressionInfo](../../Syntax/StringConcatenationExpressionInfo/README.md) from the specified node\.

```csharp
public static Roslynator.CSharp.Syntax.StringConcatenationExpressionInfo StringConcatenationExpressionInfo(Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.SemanticModel semanticModel, bool walkDownParentheses = true, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**walkDownParentheses** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Roslynator\.CSharp\.Syntax\.[StringConcatenationExpressionInfo](../../Syntax/StringConcatenationExpressionInfo/README.md)

