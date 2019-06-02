# SyntaxAccessibility\.IsValidAccessibility\(SyntaxNode, Accessibility, Boolean\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxAccessibility](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns true if the node can have specified accessibility\.

```csharp
public static bool IsValidAccessibility(Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.Accessibility accessibility, bool ignoreOverride = false)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**accessibility** &emsp; Microsoft\.CodeAnalysis\.[Accessibility](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.accessibility)

**ignoreOverride** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

Ignore "override" modifier\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

