# SyntaxExtensions\.TryGetContainingList\(SyntaxTrivia, SyntaxTriviaList, Boolean, Boolean\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Gets a [SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist) the specified trivia is contained in\.

```csharp
public static bool TryGetContainingList(this Microsoft.CodeAnalysis.SyntaxTrivia trivia, out Microsoft.CodeAnalysis.SyntaxTriviaList triviaList, bool allowLeading = true, bool allowTrailing = true)
```

### Parameters

**trivia** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**triviaList** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist)

**allowLeading** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

If true, trivia can be part of leading trivia\.

**allowTrailing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

If true, trivia can be part of trailing trivia\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

