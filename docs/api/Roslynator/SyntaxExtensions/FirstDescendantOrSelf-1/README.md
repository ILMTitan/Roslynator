# SyntaxExtensions\.FirstDescendantOrSelf Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [FirstDescendantOrSelf\<TNode>(SyntaxNode, Func\<SyntaxNode, Boolean>, Boolean)](#Roslynator_SyntaxExtensions_FirstDescendantOrSelf__1_Microsoft_CodeAnalysis_SyntaxNode_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_) | Searches a list of descendant nodes \(including this node\) in prefix document order and returns first descendant of type **TNode**\. |
| [FirstDescendantOrSelf\<TNode>(SyntaxNode, TextSpan, Func\<SyntaxNode, Boolean>, Boolean)](#Roslynator_SyntaxExtensions_FirstDescendantOrSelf__1_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_Text_TextSpan_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_) | Searches a list of descendant nodes \(including this node\) in prefix document order and returns first descendant of type **TNode**\. |

## FirstDescendantOrSelf\<TNode>\(SyntaxNode, Func\<SyntaxNode, Boolean>, Boolean\) <a name="Roslynator_SyntaxExtensions_FirstDescendantOrSelf__1_Microsoft_CodeAnalysis_SyntaxNode_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_"></a>

### Summary

Searches a list of descendant nodes \(including this node\) in prefix document order and returns first descendant of type **TNode**\.

```csharp
public static TNode FirstDescendantOrSelf<TNode>(this Microsoft.CodeAnalysis.SyntaxNode node, Func<Microsoft.CodeAnalysis.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**descendIntoChildren** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

**descendIntoTrivia** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

TNode

## FirstDescendantOrSelf\<TNode>\(SyntaxNode, TextSpan, Func\<SyntaxNode, Boolean>, Boolean\) <a name="Roslynator_SyntaxExtensions_FirstDescendantOrSelf__1_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_Text_TextSpan_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_"></a>

### Summary

Searches a list of descendant nodes \(including this node\) in prefix document order and returns first descendant of type **TNode**\.

```csharp
public static TNode FirstDescendantOrSelf<TNode>(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.Text.TextSpan span, Func<Microsoft.CodeAnalysis.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

**descendIntoChildren** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

**descendIntoTrivia** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

TNode

