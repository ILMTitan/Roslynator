# SyntaxAccessibility\.WithExplicitAccessibility\<TNode>\(TNode, Accessibility, IComparer\<SyntaxKind>\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxAccessibility](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Creates a new node with the specified explicit accessibility updated\.

```csharp
public static TNode WithExplicitAccessibility<TNode>(TNode node, Microsoft.CodeAnalysis.Accessibility newAccessibility, System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.SyntaxKind> comparer = null) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; TNode

**newAccessibility** &emsp; Microsoft\.CodeAnalysis\.[Accessibility](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.accessibility)

**comparer** &emsp; System\.Collections\.Generic\.[IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1)\<Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)>

### Returns

TNode

