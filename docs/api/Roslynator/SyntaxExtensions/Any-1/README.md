# SyntaxExtensions\.Any Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Any(SyntaxTokenList, Func\<SyntaxToken, Boolean>)](../Any/README.md#Roslynator_SyntaxExtensions_Any_Microsoft_CodeAnalysis_SyntaxTokenList_System_Func_Microsoft_CodeAnalysis_SyntaxToken_System_Boolean__) | Returns true if any token in a [SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist) matches the predicate\. |
| [Any(SyntaxTriviaList, Func\<SyntaxTrivia, Boolean>)](../Any/README.md#Roslynator_SyntaxExtensions_Any_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Func_Microsoft_CodeAnalysis_SyntaxTrivia_System_Boolean__) | Returns true if any trivia in a [SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist) matches the predicate\. |
| [Any\<TNode>(SeparatedSyntaxList\<TNode>, Func\<TNode, Boolean>)](#Roslynator_SyntaxExtensions_Any__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Func___0_System_Boolean__) | Returns true if any node in a list matches the predicate\. |
| [Any\<TNode>(SyntaxList\<TNode>, Func\<TNode, Boolean>)](#Roslynator_SyntaxExtensions_Any__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Func___0_System_Boolean__) | Returns true if any node in a list matches the predicate\. |

## Any\(SyntaxTokenList, Func\<SyntaxToken, Boolean>\) <a name="Roslynator_SyntaxExtensions_Any_Microsoft_CodeAnalysis_SyntaxTokenList_System_Func_Microsoft_CodeAnalysis_SyntaxToken_System_Boolean__"></a>

### Summary

Returns true if any token in a [SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist) matches the predicate\.

```csharp
public static bool Any(this Microsoft.CodeAnalysis.SyntaxTokenList list, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> predicate)
```

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## Any\(SyntaxTriviaList, Func\<SyntaxTrivia, Boolean>\) <a name="Roslynator_SyntaxExtensions_Any_Microsoft_CodeAnalysis_SyntaxTriviaList_System_Func_Microsoft_CodeAnalysis_SyntaxTrivia_System_Boolean__"></a>

### Summary

Returns true if any trivia in a [SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist) matches the predicate\.

```csharp
public static bool Any(this Microsoft.CodeAnalysis.SyntaxTriviaList list, Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool> predicate)
```

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist)

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## Any\<TNode>\(SeparatedSyntaxList\<TNode>, Func\<TNode, Boolean>\) <a name="Roslynator_SyntaxExtensions_Any__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Func___0_System_Boolean__"></a>

### Summary

Returns true if any node in a list matches the predicate\.

```csharp
public static bool Any<TNode>(this Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> list, Func<TNode, bool> predicate) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode>

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<TNode, [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## Any\<TNode>\(SyntaxList\<TNode>, Func\<TNode, Boolean>\) <a name="Roslynator_SyntaxExtensions_Any__1_Microsoft_CodeAnalysis_SyntaxList___0__System_Func___0_System_Boolean__"></a>

### Summary

Returns true if any node in a list matches the predicate\.

```csharp
public static bool Any<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, Func<TNode, bool> predicate) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list** &emsp; Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<TNode>

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<TNode, [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

