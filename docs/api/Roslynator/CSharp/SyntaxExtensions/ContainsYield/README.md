# SyntaxExtensions\.ContainsYield Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ContainsYield(LocalFunctionStatementSyntax)](#Roslynator_CSharp_SyntaxExtensions_ContainsYield_Microsoft_CodeAnalysis_CSharp_Syntax_LocalFunctionStatementSyntax_) | Returns true if the specified local function contains yield statement\. Nested local functions are excluded\. |
| [ContainsYield(MethodDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_ContainsYield_Microsoft_CodeAnalysis_CSharp_Syntax_MethodDeclarationSyntax_) | Returns true if the specified method contains yield statement\. Nested local functions are excluded\. |

## ContainsYield\(LocalFunctionStatementSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_ContainsYield_Microsoft_CodeAnalysis_CSharp_Syntax_LocalFunctionStatementSyntax_"></a>

### Summary

Returns true if the specified local function contains yield statement\. Nested local functions are excluded\.

```csharp
public static bool ContainsYield(this Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax localFunctionStatement)
```

### Parameters

**localFunctionStatement** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[LocalFunctionStatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.localfunctionstatementsyntax)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## ContainsYield\(MethodDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_ContainsYield_Microsoft_CodeAnalysis_CSharp_Syntax_MethodDeclarationSyntax_"></a>

### Summary

Returns true if the specified method contains yield statement\. Nested local functions are excluded\.

```csharp
public static bool ContainsYield(this Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax methodDeclaration)
```

### Parameters

**methodDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[MethodDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.methoddeclarationsyntax)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

