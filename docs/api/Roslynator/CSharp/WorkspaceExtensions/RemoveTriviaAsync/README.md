# WorkspaceExtensions\.RemoveTriviaAsync\(Document, TextSpan, CancellationToken\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.Workspaces\.dll

## Summary

Creates a new document with trivia inside the specified span removed\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> RemoveTriviaAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.Text.TextSpan span, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &emsp; Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

