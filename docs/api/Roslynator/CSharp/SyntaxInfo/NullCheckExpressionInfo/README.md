# SyntaxInfo\.NullCheckExpressionInfo Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [NullCheckExpressionInfo(SyntaxNode, NullCheckStyles, Boolean, Boolean)](#Roslynator_CSharp_SyntaxInfo_NullCheckExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_Roslynator_CSharp_NullCheckStyles_System_Boolean_System_Boolean_) | Creates a new [NullCheckExpressionInfo](../../Syntax/NullCheckExpressionInfo/README.md) from the specified node\. |
| [NullCheckExpressionInfo(SyntaxNode, SemanticModel, NullCheckStyles, Boolean, Boolean, CancellationToken)](#Roslynator_CSharp_SyntaxInfo_NullCheckExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_SemanticModel_Roslynator_CSharp_NullCheckStyles_System_Boolean_System_Boolean_System_Threading_CancellationToken_) | Creates a new [NullCheckExpressionInfo](../../Syntax/NullCheckExpressionInfo/README.md) from the specified node\. |

## NullCheckExpressionInfo\(SyntaxNode, NullCheckStyles, Boolean, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_NullCheckExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_Roslynator_CSharp_NullCheckStyles_System_Boolean_System_Boolean_"></a>

### Summary

Creates a new [NullCheckExpressionInfo](../../Syntax/NullCheckExpressionInfo/README.md) from the specified node\.

```csharp
public static Roslynator.CSharp.Syntax.NullCheckExpressionInfo NullCheckExpressionInfo(Microsoft.CodeAnalysis.SyntaxNode node, Roslynator.CSharp.NullCheckStyles allowedStyles = ComparisonToNull | IsPattern, bool walkDownParentheses = true, bool allowMissing = false)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**allowedStyles** &emsp; Roslynator\.CSharp\.[NullCheckStyles](../../NullCheckStyles/README.md)

**walkDownParentheses** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**allowMissing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Roslynator\.CSharp\.Syntax\.[NullCheckExpressionInfo](../../Syntax/NullCheckExpressionInfo/README.md)

## NullCheckExpressionInfo\(SyntaxNode, SemanticModel, NullCheckStyles, Boolean, Boolean, CancellationToken\) <a name="Roslynator_CSharp_SyntaxInfo_NullCheckExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_SemanticModel_Roslynator_CSharp_NullCheckStyles_System_Boolean_System_Boolean_System_Threading_CancellationToken_"></a>

### Summary

Creates a new [NullCheckExpressionInfo](../../Syntax/NullCheckExpressionInfo/README.md) from the specified node\.

```csharp
public static Roslynator.CSharp.Syntax.NullCheckExpressionInfo NullCheckExpressionInfo(Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.SemanticModel semanticModel, Roslynator.CSharp.NullCheckStyles allowedStyles = All, bool walkDownParentheses = true, bool allowMissing = false, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**allowedStyles** &emsp; Roslynator\.CSharp\.[NullCheckStyles](../../NullCheckStyles/README.md)

**walkDownParentheses** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**allowMissing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Roslynator\.CSharp\.Syntax\.[NullCheckExpressionInfo](../../Syntax/NullCheckExpressionInfo/README.md)

