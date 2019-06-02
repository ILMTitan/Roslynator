# CSharpExtensions\.IsDefaultValue\(SemanticModel, ITypeSymbol, ExpressionSyntax, CancellationToken\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[CSharpExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns true if the specified expression represents default value of the specified type\.

```csharp
public static bool IsDefaultValue(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax expression, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**expression** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

