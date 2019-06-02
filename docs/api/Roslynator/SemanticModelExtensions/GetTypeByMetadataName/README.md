# SemanticModelExtensions\.GetTypeByMetadataName\(SemanticModel, String\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SemanticModelExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Returns the type within the compilation's assembly using its canonical CLR metadata name\.

```csharp
public static Microsoft.CodeAnalysis.INamedTypeSymbol GetTypeByMetadataName(this Microsoft.CodeAnalysis.SemanticModel semanticModel, string fullyQualifiedMetadataName)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**fullyQualifiedMetadataName** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

