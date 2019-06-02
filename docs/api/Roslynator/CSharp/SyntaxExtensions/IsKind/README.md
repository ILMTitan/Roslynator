# SyntaxExtensions\.IsKind Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IsKind(SyntaxNode, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node's kind is one of the specified kinds\. |
| [IsKind(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node's kind is one of the specified kinds\. |
| [IsKind(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node's kind is one of the specified kinds\. |
| [IsKind(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node's kind is one of the specified kinds\. |
| [IsKind(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node's kind is one of the specified kinds\. |
| [IsKind(SyntaxToken, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token's kind is one of the specified kinds\. |
| [IsKind(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token's kind is one of the specified kinds\. |
| [IsKind(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token's kind is one of the specified kinds\. |
| [IsKind(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token's kind is one of the specified kinds\. |
| [IsKind(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token's kind is one of the specified kinds\. |
| [IsKind(SyntaxTrivia, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a trivia's kind is one of the specified kinds\. |
| [IsKind(SyntaxTrivia, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token's kind is one of the specified kinds\. |
| [IsKind(SyntaxTrivia, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token's kind is one of the specified kinds\. |
| [IsKind(SyntaxTrivia, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token's kind is one of the specified kinds\. |
| [IsKind(SyntaxTrivia, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token's kind is one of the specified kinds\. |

## IsKind\(SyntaxNode, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind4** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind4** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind5** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind6)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind4** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind5** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind6** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxToken, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2)
```

### Parameters

**token** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3)
```

### Parameters

**token** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4)
```

### Parameters

**token** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind4** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5)
```

### Parameters

**token** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind4** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind5** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind6)
```

### Parameters

**token** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind4** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind5** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind6** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxTrivia, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a trivia's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxTrivia trivia, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2)
```

### Parameters

**trivia** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxTrivia, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxTrivia trivia, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3)
```

### Parameters

**trivia** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxTrivia, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxTrivia trivia, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4)
```

### Parameters

**trivia** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind4** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxTrivia, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxTrivia trivia, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5)
```

### Parameters

**trivia** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind4** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind5** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsKind\(SyntaxTrivia, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsKind_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token's kind is one of the specified kinds\.

```csharp
public static bool IsKind(this Microsoft.CodeAnalysis.SyntaxTrivia trivia, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind6)
```

### Parameters

**trivia** &emsp; Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**kind1** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind2** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind3** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind4** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind5** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

**kind6** &emsp; Microsoft\.CodeAnalysis\.CSharp\.[SyntaxKind](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

