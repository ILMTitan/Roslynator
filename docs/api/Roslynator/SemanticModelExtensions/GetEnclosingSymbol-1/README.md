# SemanticModelExtensions\.GetEnclosingSymbol\<TSymbol>\(SemanticModel, Int32, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SemanticModelExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Returns the innermost symbol of type **TSymbol** that the specified position is considered inside of\.

```csharp
public static TSymbol GetEnclosingSymbol<TSymbol>(this Microsoft.CodeAnalysis.SemanticModel semanticModel, int position, System.Threading.CancellationToken cancellationToken = default) where TSymbol : Microsoft.CodeAnalysis.ISymbol
```

### Type Parameters

**TSymbol**

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**position** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

TSymbol

