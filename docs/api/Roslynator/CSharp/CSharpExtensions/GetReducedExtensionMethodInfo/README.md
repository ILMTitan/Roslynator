# CSharpExtensions\.GetReducedExtensionMethodInfo\(SemanticModel, ExpressionSyntax, CancellationToken\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[CSharpExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns what extension method symbol, if any, the specified expression syntax bound to\.

```csharp
public static Roslynator.ExtensionMethodSymbolInfo GetReducedExtensionMethodInfo(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax expression, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**expression** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Roslynator\.[ExtensionMethodSymbolInfo](../../../ExtensionMethodSymbolInfo/README.md)

