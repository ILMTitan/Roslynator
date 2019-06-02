# WorkspaceExtensions\.ReplaceTokenAsync Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ReplaceTokenAsync(Document, SyntaxToken, IEnumerable\<SyntaxToken>, CancellationToken)](#Roslynator_WorkspaceExtensions_ReplaceTokenAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_SyntaxToken_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxToken__System_Threading_CancellationToken_) | Creates a new document with the specified old token replaced with new tokens\. |
| [ReplaceTokenAsync(Document, SyntaxToken, SyntaxToken, CancellationToken)](#Roslynator_WorkspaceExtensions_ReplaceTokenAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_SyntaxToken_System_Threading_CancellationToken_) | Creates a new document with the specified old token replaced with a new token\. |

## ReplaceTokenAsync\(Document, SyntaxToken, IEnumerable\<SyntaxToken>, CancellationToken\) <a name="Roslynator_WorkspaceExtensions_ReplaceTokenAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_SyntaxToken_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxToken__System_Threading_CancellationToken_"></a>

### Summary

Creates a new document with the specified old token replaced with new tokens\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> ReplaceTokenAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.SyntaxToken oldToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken> newTokens, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &emsp; Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**oldToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**newTokens** &emsp; System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)>

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

## ReplaceTokenAsync\(Document, SyntaxToken, SyntaxToken, CancellationToken\) <a name="Roslynator_WorkspaceExtensions_ReplaceTokenAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_SyntaxToken_System_Threading_CancellationToken_"></a>

### Summary

Creates a new document with the specified old token replaced with a new token\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> ReplaceTokenAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.SyntaxToken oldToken, Microsoft.CodeAnalysis.SyntaxToken newToken, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &emsp; Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**oldToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**newToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

