# CSharpExtensions\.GetSymbol Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[CSharpExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GetSymbol(SemanticModel, AttributeSyntax, CancellationToken)](#Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_AttributeSyntax_System_Threading_CancellationToken_) | Returns what symbol, if any, the specified attribute syntax bound to\. |
| [GetSymbol(SemanticModel, ConstructorInitializerSyntax, CancellationToken)](#Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_ConstructorInitializerSyntax_System_Threading_CancellationToken_) | Returns what symbol, if any, the specified constructor initializer syntax bound to\. |
| [GetSymbol(SemanticModel, CrefSyntax, CancellationToken)](#Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_CrefSyntax_System_Threading_CancellationToken_) | Returns what symbol, if any, the specified cref syntax bound to\. |
| [GetSymbol(SemanticModel, ExpressionSyntax, CancellationToken)](#Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_System_Threading_CancellationToken_) | Returns what symbol, if any, the specified expression syntax bound to\. |
| [GetSymbol(SemanticModel, OrderingSyntax, CancellationToken)](#Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_OrderingSyntax_System_Threading_CancellationToken_) | Returns what symbol, if any, the specified ordering syntax bound to\. |
| [GetSymbol(SemanticModel, SelectOrGroupClauseSyntax, CancellationToken)](#Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_SelectOrGroupClauseSyntax_System_Threading_CancellationToken_) | Returns what symbol, if any, the specified select or group clause bound to\. |

## GetSymbol\(SemanticModel, AttributeSyntax, CancellationToken\) <a name="Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_AttributeSyntax_System_Threading_CancellationToken_"></a>

### Summary

Returns what symbol, if any, the specified attribute syntax bound to\.

```csharp
public static Microsoft.CodeAnalysis.ISymbol GetSymbol(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax attribute, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**attribute** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AttributeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.attributesyntax)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

## GetSymbol\(SemanticModel, ConstructorInitializerSyntax, CancellationToken\) <a name="Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_ConstructorInitializerSyntax_System_Threading_CancellationToken_"></a>

### Summary

Returns what symbol, if any, the specified constructor initializer syntax bound to\.

```csharp
public static Microsoft.CodeAnalysis.ISymbol GetSymbol(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax constructorInitializer, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**constructorInitializer** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ConstructorInitializerSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.constructorinitializersyntax)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

## GetSymbol\(SemanticModel, CrefSyntax, CancellationToken\) <a name="Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_CrefSyntax_System_Threading_CancellationToken_"></a>

### Summary

Returns what symbol, if any, the specified cref syntax bound to\.

```csharp
public static Microsoft.CodeAnalysis.ISymbol GetSymbol(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax cref, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**cref** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[CrefSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.crefsyntax)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

## GetSymbol\(SemanticModel, ExpressionSyntax, CancellationToken\) <a name="Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_System_Threading_CancellationToken_"></a>

### Summary

Returns what symbol, if any, the specified expression syntax bound to\.

```csharp
public static Microsoft.CodeAnalysis.ISymbol GetSymbol(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax expression, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**expression** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

## GetSymbol\(SemanticModel, OrderingSyntax, CancellationToken\) <a name="Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_OrderingSyntax_System_Threading_CancellationToken_"></a>

### Summary

Returns what symbol, if any, the specified ordering syntax bound to\.

```csharp
public static Microsoft.CodeAnalysis.ISymbol GetSymbol(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax ordering, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**ordering** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[OrderingSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.orderingsyntax)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

## GetSymbol\(SemanticModel, SelectOrGroupClauseSyntax, CancellationToken\) <a name="Roslynator_CSharp_CSharpExtensions_GetSymbol_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_SelectOrGroupClauseSyntax_System_Threading_CancellationToken_"></a>

### Summary

Returns what symbol, if any, the specified select or group clause bound to\.

```csharp
public static Microsoft.CodeAnalysis.ISymbol GetSymbol(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax selectOrGroupClause, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**selectOrGroupClause** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[SelectOrGroupClauseSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.selectorgroupclausesyntax)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

