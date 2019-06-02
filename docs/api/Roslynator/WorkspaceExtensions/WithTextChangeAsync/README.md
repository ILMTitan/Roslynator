# WorkspaceExtensions\.WithTextChangeAsync\(Document, TextChange, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Summary

Creates a new document updated with the specified text change\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> WithTextChangeAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.Text.TextChange textChange, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &emsp; Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**textChange** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextChange](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textchange)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

