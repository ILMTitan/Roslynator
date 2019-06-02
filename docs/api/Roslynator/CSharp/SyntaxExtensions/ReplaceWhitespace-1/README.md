# SyntaxExtensions\.ReplaceWhitespace\<TNode>\(TNode, SyntaxTrivia, TextSpan?\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Creates a new node with the whitespace replaced\.

```csharp
public static TNode ReplaceWhitespace<TNode>(this TNode node, Microsoft.CodeAnalysis.SyntaxTrivia replacement, Microsoft.CodeAnalysis.Text.TextSpan? span = null) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node** &emsp; TNode

**replacement** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)?

### Returns

TNode

