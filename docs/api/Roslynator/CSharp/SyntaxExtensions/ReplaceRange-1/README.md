# SyntaxExtensions\.ReplaceRange Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ReplaceRange(SyntaxTokenList, Int32, Int32, IEnumerable\<SyntaxToken>)](../ReplaceRange/README.md#Roslynator_CSharp_SyntaxExtensions_ReplaceRange_Microsoft_CodeAnalysis_SyntaxTokenList_System_Int32_System_Int32_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxToken__) | Creates a new list with the tokens in the specified range replaced with new tokens\. |
| [ReplaceRange(SyntaxTriviaList, Int32, Int32, IEnumerable\<SyntaxTrivia>)](../ReplaceRange/README.md#Roslynator_CSharp_SyntaxExtensions_ReplaceRange_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Int32_System_Int32_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxTrivia__) | Creates a new list with the trivia in the specified range replaced with new trivia\. |
| [ReplaceRange\<TNode>(SeparatedSyntaxList\<TNode>, Int32, Int32, IEnumerable\<TNode>)](#Roslynator_CSharp_SyntaxExtensions_ReplaceRange__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32_System_Int32_System_Collections_Generic_IEnumerable___0__) | Creates a new list with the elements in the specified range replaced with new nodes\. |
| [ReplaceRange\<TNode>(SyntaxList\<TNode>, Int32, Int32, IEnumerable\<TNode>)](#Roslynator_CSharp_SyntaxExtensions_ReplaceRange__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Int32_System_Int32_System_Collections_Generic_IEnumerable___0__) | Creates a new list with the elements in the specified range replaced with new nodes\. |

## ReplaceRange\(SyntaxTokenList, Int32, Int32, IEnumerable\<SyntaxToken>\) <a name="Roslynator_CSharp_SyntaxExtensions_ReplaceRange_Microsoft_CodeAnalysis_SyntaxTokenList_System_Int32_System_Int32_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxToken__"></a>

### Summary

Creates a new list with the tokens in the specified range replaced with new tokens\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxTokenList ReplaceRange(this Microsoft.CodeAnalysis.SyntaxTokenList list, int index, int count, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken> newTokens)
```

### Parameters

**list**

**index**

**count**

**newTokens**

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

## ReplaceRange\(SyntaxTriviaList, Int32, Int32, IEnumerable\<SyntaxTrivia>\) <a name="Roslynator_CSharp_SyntaxExtensions_ReplaceRange_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Int32_System_Int32_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxTrivia__"></a>

### Summary

Creates a new list with the trivia in the specified range replaced with new trivia\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxTriviaList ReplaceRange(this Microsoft.CodeAnalysis.SyntaxTriviaList list, int index, int count, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia> newTrivia)
```

### Parameters

**list**

**index**

**count**

**newTrivia**

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist)

## ReplaceRange\<TNode>\(SeparatedSyntaxList\<TNode>, Int32, Int32, IEnumerable\<TNode>\) <a name="Roslynator_CSharp_SyntaxExtensions_ReplaceRange__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32_System_Int32_System_Collections_Generic_IEnumerable___0__"></a>

### Summary

Creates a new list with the elements in the specified range replaced with new nodes\.

```csharp
public static Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> ReplaceRange<TNode>(this Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> list, int index, int count, System.Collections.Generic.IEnumerable<TNode> newNodes) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list**

**index**

**count**

**newNodes**

### Returns

Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode>

## ReplaceRange\<TNode>\(SyntaxList\<TNode>, Int32, Int32, IEnumerable\<TNode>\) <a name="Roslynator_CSharp_SyntaxExtensions_ReplaceRange__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Int32_System_Int32_System_Collections_Generic_IEnumerable___0__"></a>

### Summary

Creates a new list with the elements in the specified range replaced with new nodes\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxList<TNode> ReplaceRange<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, int index, int count, System.Collections.Generic.IEnumerable<TNode> newNodes) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list**

**index**

**count**

**newNodes**

### Returns

Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<TNode>

