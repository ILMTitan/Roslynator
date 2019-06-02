# SyntaxExtensions\.WithoutLeadingTrivia Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WithoutLeadingTrivia(SyntaxNodeOrToken)](#Roslynator_SyntaxExtensions_WithoutLeadingTrivia_Microsoft_CodeAnalysis_SyntaxNodeOrToken_) | Creates a new [SyntaxNodeOrToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnodeortoken) with the leading trivia removed\. |
| [WithoutLeadingTrivia(SyntaxToken)](#Roslynator_SyntaxExtensions_WithoutLeadingTrivia_Microsoft_CodeAnalysis_SyntaxToken_) | Creates a new token from this token with the leading trivia removed\. |

## WithoutLeadingTrivia\(SyntaxNodeOrToken\) <a name="Roslynator_SyntaxExtensions_WithoutLeadingTrivia_Microsoft_CodeAnalysis_SyntaxNodeOrToken_"></a>

### Summary

Creates a new [SyntaxNodeOrToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnodeortoken) with the leading trivia removed\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxNodeOrToken WithoutLeadingTrivia(this Microsoft.CodeAnalysis.SyntaxNodeOrToken nodeOrToken)
```

### Parameters

**nodeOrToken** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNodeOrToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnodeortoken)

### Returns

Microsoft\.CodeAnalysis\.[SyntaxNodeOrToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnodeortoken)

## WithoutLeadingTrivia\(SyntaxToken\) <a name="Roslynator_SyntaxExtensions_WithoutLeadingTrivia_Microsoft_CodeAnalysis_SyntaxToken_"></a>

### Summary

Creates a new token from this token with the leading trivia removed\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxToken WithoutLeadingTrivia(this Microsoft.CodeAnalysis.SyntaxToken token)
```

### Parameters

**token** &emsp; Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

### Returns

Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

