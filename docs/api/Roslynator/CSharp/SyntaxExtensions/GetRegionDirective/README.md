# SyntaxExtensions\.GetRegionDirective\(EndRegionDirectiveTriviaSyntax\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns region directive that is related to the specified endregion directive\. Returns null if no matching region directive is found\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax GetRegionDirective(this Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax endRegionDirective)
```

### Parameters

**endRegionDirective** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[EndRegionDirectiveTriviaSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.endregiondirectivetriviasyntax)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[RegionDirectiveTriviaSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.regiondirectivetriviasyntax)

