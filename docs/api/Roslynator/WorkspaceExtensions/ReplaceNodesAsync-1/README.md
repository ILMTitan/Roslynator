# WorkspaceExtensions\.ReplaceNodesAsync Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ReplaceNodesAsync\<TNode>(Document, IEnumerable\<TNode>, Func\<TNode, TNode, SyntaxNode>, CancellationToken)](#Roslynator_WorkspaceExtensions_ReplaceNodesAsync__1_Microsoft_CodeAnalysis_Document_System_Collections_Generic_IEnumerable___0__System_Func___0___0_Microsoft_CodeAnalysis_SyntaxNode__System_Threading_CancellationToken_) | Creates a new document with the specified old nodes replaced with new nodes\. |
| [ReplaceNodesAsync\<TNode>(Solution, IEnumerable\<TNode>, Func\<TNode, TNode, SyntaxNode>, CancellationToken)](#Roslynator_WorkspaceExtensions_ReplaceNodesAsync__1_Microsoft_CodeAnalysis_Solution_System_Collections_Generic_IEnumerable___0__System_Func___0___0_Microsoft_CodeAnalysis_SyntaxNode__System_Threading_CancellationToken_) | Creates a new solution with the specified old nodes replaced with new nodes\. |

## ReplaceNodesAsync\<TNode>\(Document, IEnumerable\<TNode>, Func\<TNode, TNode, SyntaxNode>, CancellationToken\) <a name="Roslynator_WorkspaceExtensions_ReplaceNodesAsync__1_Microsoft_CodeAnalysis_Document_System_Collections_Generic_IEnumerable___0__System_Func___0___0_Microsoft_CodeAnalysis_SyntaxNode__System_Threading_CancellationToken_"></a>

### Summary

Creates a new document with the specified old nodes replaced with new nodes\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> ReplaceNodesAsync<TNode>(this Microsoft.CodeAnalysis.Document document, System.Collections.Generic.IEnumerable<TNode> nodes, Func<TNode, TNode, Microsoft.CodeAnalysis.SyntaxNode> computeReplacementNode, System.Threading.CancellationToken cancellationToken = default) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**document** &emsp; Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**nodes** &emsp; System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<TNode>

**computeReplacementNode** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-3)\<TNode, TNode, Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)>

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

## ReplaceNodesAsync\<TNode>\(Solution, IEnumerable\<TNode>, Func\<TNode, TNode, SyntaxNode>, CancellationToken\) <a name="Roslynator_WorkspaceExtensions_ReplaceNodesAsync__1_Microsoft_CodeAnalysis_Solution_System_Collections_Generic_IEnumerable___0__System_Func___0___0_Microsoft_CodeAnalysis_SyntaxNode__System_Threading_CancellationToken_"></a>

### Summary

Creates a new solution with the specified old nodes replaced with new nodes\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Solution> ReplaceNodesAsync<TNode>(this Microsoft.CodeAnalysis.Solution solution, System.Collections.Generic.IEnumerable<TNode> nodes, Func<TNode, TNode, Microsoft.CodeAnalysis.SyntaxNode> computeReplacementNodes, System.Threading.CancellationToken cancellationToken = default) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**solution** &emsp; Microsoft\.CodeAnalysis\.[Solution](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.solution)

**nodes** &emsp; System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<TNode>

**computeReplacementNodes** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-3)\<TNode, TNode, Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)>

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<Microsoft\.CodeAnalysis\.[Solution](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.solution)>

