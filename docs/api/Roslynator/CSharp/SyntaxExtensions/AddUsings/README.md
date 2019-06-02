# SyntaxExtensions\.AddUsings\(CompilationUnitSyntax, Boolean, UsingDirectiveSyntax\[\]\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Creates a new [CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax) with the specified using directives added\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax AddUsings(this Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax compilationUnit, bool keepSingleLineCommentsOnTop, params Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax[] usings)
```

### Parameters

**compilationUnit** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax)

**keepSingleLineCommentsOnTop** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**usings** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[UsingDirectiveSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.usingdirectivesyntax)\[\]

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax)

