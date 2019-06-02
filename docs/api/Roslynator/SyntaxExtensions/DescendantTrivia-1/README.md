# SyntaxExtensions\.DescendantTrivia Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [DescendantTrivia\<TNode>(SyntaxList\<TNode>, Func\<SyntaxNode, Boolean>, Boolean)](#Roslynator_SyntaxExtensions_DescendantTrivia__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_) | Get a list of all the trivia associated with the nodes in the list\. |
| [DescendantTrivia\<TNode>(SyntaxList\<TNode>, TextSpan, Func\<SyntaxNode, Boolean>, Boolean)](#Roslynator_SyntaxExtensions_DescendantTrivia__1_Microsoft_CodeAnalysis_SyntaxList___0__Microsoft_CodeAnalysis_Text_TextSpan_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_) | Get a list of all the trivia associated with the nodes in the list\. |

## DescendantTrivia\<TNode>\(SyntaxList\<TNode>, Func\<SyntaxNode, Boolean>, Boolean\) <a name="Roslynator_SyntaxExtensions_DescendantTrivia__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_"></a>

### Summary

Get a list of all the trivia associated with the nodes in the list\.

```csharp
public static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia> DescendantTrivia<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, Func<Microsoft.CodeAnalysis.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<TNode>

**descendIntoChildren** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

**descendIntoTrivia** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)>

## DescendantTrivia\<TNode>\(SyntaxList\<TNode>, TextSpan, Func\<SyntaxNode, Boolean>, Boolean\) <a name="Roslynator_SyntaxExtensions_DescendantTrivia__1_Microsoft_CodeAnalysis_SyntaxList___0__Microsoft_CodeAnalysis_Text_TextSpan_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_"></a>

### Summary

Get a list of all the trivia associated with the nodes in the list\.

```csharp
public static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia> DescendantTrivia<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, Microsoft.CodeAnalysis.Text.TextSpan span, Func<Microsoft.CodeAnalysis.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<TNode>

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

**descendIntoChildren** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

**descendIntoTrivia** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)>

