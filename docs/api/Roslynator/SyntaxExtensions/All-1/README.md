# SyntaxExtensions\.All Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [All(SyntaxTokenList, Func\<SyntaxToken, Boolean>)](../All/README.md#Roslynator_SyntaxExtensions_All_Microsoft_CodeAnalysis_SyntaxTokenList_System_Func_Microsoft_CodeAnalysis_SyntaxToken_System_Boolean__) | Returns true if all tokens in a [SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist) matches the predicate\. |
| [All(SyntaxTriviaList, Func\<SyntaxTrivia, Boolean>)](../All/README.md#Roslynator_SyntaxExtensions_All_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Func_Microsoft_CodeAnalysis_SyntaxTrivia_System_Boolean__) | Returns true if all trivia in a [SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist) matches the predicate\. |
| [All\<TNode>(SeparatedSyntaxList\<TNode>, Func\<TNode, Boolean>)](#Roslynator_SyntaxExtensions_All__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Func___0_System_Boolean__) | Returns true if all nodes in a list matches the predicate\. |
| [All\<TNode>(SyntaxList\<TNode>, Func\<TNode, Boolean>)](#Roslynator_SyntaxExtensions_All__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Func___0_System_Boolean__) | Returns true if all nodes in a list matches the predicate\. |

## All\(SyntaxTokenList, Func\<SyntaxToken, Boolean>\) <a name="Roslynator_SyntaxExtensions_All_Microsoft_CodeAnalysis_SyntaxTokenList_System_Func_Microsoft_CodeAnalysis_SyntaxToken_System_Boolean__"></a>

### Summary

Returns true if all tokens in a [SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist) matches the predicate\.

```csharp
public static bool All(this Microsoft.CodeAnalysis.SyntaxTokenList list, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> predicate)
```

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## All\(SyntaxTriviaList, Func\<SyntaxTrivia, Boolean>\) <a name="Roslynator_SyntaxExtensions_All_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Func_Microsoft_CodeAnalysis_SyntaxTrivia_System_Boolean__"></a>

### Summary

Returns true if all trivia in a [SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist) matches the predicate\.

```csharp
public static bool All(this Microsoft.CodeAnalysis.SyntaxTriviaList list, Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool> predicate)
```

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist)

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## All\<TNode>\(SeparatedSyntaxList\<TNode>, Func\<TNode, Boolean>\) <a name="Roslynator_SyntaxExtensions_All__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Func___0_System_Boolean__"></a>

### Summary

Returns true if all nodes in a list matches the predicate\.

```csharp
public static bool All<TNode>(this Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> list, Func<TNode, bool> predicate) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode>

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<TNode, [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## All\<TNode>\(SyntaxList\<TNode>, Func\<TNode, Boolean>\) <a name="Roslynator_SyntaxExtensions_All__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Func___0_System_Boolean__"></a>

### Summary

Returns true if all nodes in a list matches the predicate\.

```csharp
public static bool All<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, Func<TNode, bool> predicate) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<TNode>

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<TNode, [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

