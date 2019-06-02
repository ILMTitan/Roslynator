# WorkspaceExtensions\.InsertNodesAfterAsync\(Document, SyntaxNode, IEnumerable\<SyntaxNode>, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Summary

Creates a new document with new nodes inserted after the specified node\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> InsertNodesAfterAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.SyntaxNode nodeInList, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode> newNodes, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &emsp; Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**nodeInList** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**newNodes** &emsp; System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)>

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

