# SyntaxExtensions\.GetFirstDirective\(SyntaxNode, TextSpan, Func\<DirectiveTriviaSyntax, Boolean>\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Gets the first directive of the tree rooted by this node\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax GetFirstDirective(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.Text.TextSpan span, Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool> predicate = null)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[DirectiveTriviaSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.directivetriviasyntax), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[DirectiveTriviaSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.directivetriviasyntax)

