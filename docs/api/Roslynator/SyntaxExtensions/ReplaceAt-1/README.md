# SyntaxExtensions\.ReplaceAt Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ReplaceAt(SyntaxTokenList, Int32, SyntaxToken)](../ReplaceAt/README.md#Roslynator_SyntaxExtensions_ReplaceAt_Microsoft_CodeAnalysis_SyntaxTokenList_System_Int32_Microsoft_CodeAnalysis_SyntaxToken_) | Creates a new [SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist) with a token at the specified index replaced with a new token\. |
| [ReplaceAt(SyntaxTriviaList, Int32, SyntaxTrivia)](../ReplaceAt/README.md#Roslynator_SyntaxExtensions_ReplaceAt_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Int32_Microsoft_CodeAnalysis_SyntaxTrivia_) | Creates a new [SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist) with a trivia at the specified index replaced with new trivia\. |
| [ReplaceAt\<TNode>(SeparatedSyntaxList\<TNode>, Int32, TNode)](#Roslynator_SyntaxExtensions_ReplaceAt__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32___0_) | Creates a new list with a node at the specified index replaced with a new node\. |
| [ReplaceAt\<TNode>(SyntaxList\<TNode>, Int32, TNode)](#Roslynator_SyntaxExtensions_ReplaceAt__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Int32___0_) | Creates a new list with the node at the specified index replaced with a new node\. |

## ReplaceAt\(SyntaxTokenList, Int32, SyntaxToken\) <a name="Roslynator_SyntaxExtensions_ReplaceAt_Microsoft_CodeAnalysis_SyntaxTokenList_System_Int32_Microsoft_CodeAnalysis_SyntaxToken_"></a>

### Summary

Creates a new [SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist) with a token at the specified index replaced with a new token\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxTokenList ReplaceAt(this Microsoft.CodeAnalysis.SyntaxTokenList tokenList, int index, Microsoft.CodeAnalysis.SyntaxToken newToken)
```

### Parameters

**tokenList** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

**index** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**newToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

## ReplaceAt\(SyntaxTriviaList, Int32, SyntaxTrivia\) <a name="Roslynator_SyntaxExtensions_ReplaceAt_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Int32_Microsoft_CodeAnalysis_SyntaxTrivia_"></a>

### Summary

Creates a new [SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist) with a trivia at the specified index replaced with new trivia\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxTriviaList ReplaceAt(this Microsoft.CodeAnalysis.SyntaxTriviaList triviaList, int index, Microsoft.CodeAnalysis.SyntaxTrivia newTrivia)
```

### Parameters

**triviaList** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist)

**index** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**newTrivia** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist)

## ReplaceAt\<TNode>\(SeparatedSyntaxList\<TNode>, Int32, TNode\) <a name="Roslynator_SyntaxExtensions_ReplaceAt__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32___0_"></a>

### Summary

Creates a new list with a node at the specified index replaced with a new node\.

```csharp
public static Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> ReplaceAt<TNode>(this Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> list, int index, TNode newNode) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode>

**index** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**newNode** &emsp; TNode

### Returns

Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode>

## ReplaceAt\<TNode>\(SyntaxList\<TNode>, Int32, TNode\) <a name="Roslynator_SyntaxExtensions_ReplaceAt__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Int32___0_"></a>

### Summary

Creates a new list with the node at the specified index replaced with a new node\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxList<TNode> ReplaceAt<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, int index, TNode newNode) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<TNode>

**index** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**newNode** &emsp; TNode

### Returns

Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<TNode>

