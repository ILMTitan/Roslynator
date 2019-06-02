# SyntaxExtensions\.FirstAncestor\<TNode>\(SyntaxNode, Func\<TNode, Boolean>, Boolean\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Returns the first node of type **TNode** that matches the predicate\.

```csharp
public static TNode FirstAncestor<TNode>(this Microsoft.CodeAnalysis.SyntaxNode node, Func<TNode, bool> predicate = null, bool ascendOutOfTrivia = true) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<TNode, [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

**ascendOutOfTrivia** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

TNode

