# WorkspaceExtensions\.RemoveNodeAsync\(Document, SyntaxNode, SyntaxRemoveOptions, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Summary

Creates a new document with the specified node removed\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> RemoveNodeAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.SyntaxRemoveOptions options, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &emsp; Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**options** &emsp; Microsoft\.CodeAnalysis\.[SyntaxRemoveOptions](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxremoveoptions)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

