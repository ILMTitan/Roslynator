# SyntaxTreeExtensions\.IsMultiLineSpan\(SyntaxTree, TextSpan, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxTreeExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Returns true if the specified [TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan) spans over multiple lines\.

```csharp
public static bool IsMultiLineSpan(this Microsoft.CodeAnalysis.SyntaxTree syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan span, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**syntaxTree** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTree](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtree)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

