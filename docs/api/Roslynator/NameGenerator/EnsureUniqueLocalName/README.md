# NameGenerator\.EnsureUniqueLocalName\(String, SemanticModel, Int32, Boolean, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[NameGenerator](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Return a local name that will be unique at the specified position\.

```csharp
public string EnsureUniqueLocalName(string baseName, Microsoft.CodeAnalysis.SemanticModel semanticModel, int position, bool isCaseSensitive = true, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**baseName** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**position** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**isCaseSensitive** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

