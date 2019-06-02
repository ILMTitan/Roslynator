# WorkspaceExtensions\.RemoveNodesAsync\(Document, IEnumerable\<SyntaxNode>, SyntaxRemoveOptions, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Summary

Creates a new document with the specified nodes removed\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> RemoveNodesAsync(this Microsoft.CodeAnalysis.Document document, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode> nodes, Microsoft.CodeAnalysis.SyntaxRemoveOptions options, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &emsp; Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**nodes** &emsp; System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)>

**options** &emsp; Microsoft\.CodeAnalysis\.[SyntaxRemoveOptions](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxremoveoptions)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

