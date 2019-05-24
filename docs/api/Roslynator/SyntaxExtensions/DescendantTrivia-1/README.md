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
public static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia> DescendantTrivia<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list**

**descendIntoChildren**

**descendIntoTrivia**

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)>

## DescendantTrivia\<TNode>\(SyntaxList\<TNode>, TextSpan, Func\<SyntaxNode, Boolean>, Boolean\) <a name="Roslynator_SyntaxExtensions_DescendantTrivia__1_Microsoft_CodeAnalysis_SyntaxList___0__Microsoft_CodeAnalysis_Text_TextSpan_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_"></a>

### Summary

Get a list of all the trivia associated with the nodes in the list\.

```csharp
public static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia> DescendantTrivia<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, Microsoft.CodeAnalysis.Text.TextSpan span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list**

**span**

**descendIntoChildren**

**descendIntoTrivia**

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)>

