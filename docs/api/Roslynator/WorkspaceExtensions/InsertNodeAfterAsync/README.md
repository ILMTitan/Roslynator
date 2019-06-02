# WorkspaceExtensions\.InsertNodeAfterAsync\(Document, SyntaxNode, SyntaxNode, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Summary

Creates a new document with a new node inserted after the specified node\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> InsertNodeAfterAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.SyntaxNode nodeInList, Microsoft.CodeAnalysis.SyntaxNode newNode, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &emsp; Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**nodeInList** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**newNode** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

