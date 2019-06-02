# SemanticModelExtensions\.GetEnclosingNamedType\(SemanticModel, Int32, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SemanticModelExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Returns the innermost named type symbol that the specified position is considered inside of\.

```csharp
public static Microsoft.CodeAnalysis.INamedTypeSymbol GetEnclosingNamedType(this Microsoft.CodeAnalysis.SemanticModel semanticModel, int position, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**position** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

