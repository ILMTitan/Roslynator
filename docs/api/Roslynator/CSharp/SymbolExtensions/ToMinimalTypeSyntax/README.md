# SymbolExtensions\.ToMinimalTypeSyntax Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ToMinimalTypeSyntax(INamespaceOrTypeSymbol, SemanticModel, Int32, SymbolDisplayFormat)](#Roslynator_CSharp_SymbolExtensions_ToMinimalTypeSyntax_Microsoft_CodeAnalysis_INamespaceOrTypeSymbol_Microsoft_CodeAnalysis_SemanticModel_System_Int32_Microsoft_CodeAnalysis_SymbolDisplayFormat_) | Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified namespace or type symbol |
| [ToMinimalTypeSyntax(INamespaceSymbol, SemanticModel, Int32, SymbolDisplayFormat)](#Roslynator_CSharp_SymbolExtensions_ToMinimalTypeSyntax_Microsoft_CodeAnalysis_INamespaceSymbol_Microsoft_CodeAnalysis_SemanticModel_System_Int32_Microsoft_CodeAnalysis_SymbolDisplayFormat_) | Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified namespace symbol\. |
| [ToMinimalTypeSyntax(ITypeSymbol, SemanticModel, Int32, SymbolDisplayFormat)](#Roslynator_CSharp_SymbolExtensions_ToMinimalTypeSyntax_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SemanticModel_System_Int32_Microsoft_CodeAnalysis_SymbolDisplayFormat_) | Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified type symbol\. |

## ToMinimalTypeSyntax\(INamespaceOrTypeSymbol, SemanticModel, Int32, SymbolDisplayFormat\) <a name="Roslynator_CSharp_SymbolExtensions_ToMinimalTypeSyntax_Microsoft_CodeAnalysis_INamespaceOrTypeSymbol_Microsoft_CodeAnalysis_SemanticModel_System_Int32_Microsoft_CodeAnalysis_SymbolDisplayFormat_"></a>

### Summary

Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified namespace or type symbol

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax ToMinimalTypeSyntax(this Microsoft.CodeAnalysis.INamespaceOrTypeSymbol namespaceOrTypeSymbol, Microsoft.CodeAnalysis.SemanticModel semanticModel, int position, Microsoft.CodeAnalysis.SymbolDisplayFormat format = null)
```

### Parameters

**namespaceOrTypeSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamespaceOrTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamespaceortypesymbol)

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**position** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**format** &emsp; Microsoft\.CodeAnalysis\.[SymbolDisplayFormat](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.symboldisplayformat)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax)

## ToMinimalTypeSyntax\(INamespaceSymbol, SemanticModel, Int32, SymbolDisplayFormat\) <a name="Roslynator_CSharp_SymbolExtensions_ToMinimalTypeSyntax_Microsoft_CodeAnalysis_INamespaceSymbol_Microsoft_CodeAnalysis_SemanticModel_System_Int32_Microsoft_CodeAnalysis_SymbolDisplayFormat_"></a>

### Summary

Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified namespace symbol\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax ToMinimalTypeSyntax(this Microsoft.CodeAnalysis.INamespaceSymbol namespaceSymbol, Microsoft.CodeAnalysis.SemanticModel semanticModel, int position, Microsoft.CodeAnalysis.SymbolDisplayFormat format = null)
```

### Parameters

**namespaceSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamespaceSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamespacesymbol)

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**position** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**format** &emsp; Microsoft\.CodeAnalysis\.[SymbolDisplayFormat](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.symboldisplayformat)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax)

## ToMinimalTypeSyntax\(ITypeSymbol, SemanticModel, Int32, SymbolDisplayFormat\) <a name="Roslynator_CSharp_SymbolExtensions_ToMinimalTypeSyntax_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SemanticModel_System_Int32_Microsoft_CodeAnalysis_SymbolDisplayFormat_"></a>

### Summary

Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified type symbol\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax ToMinimalTypeSyntax(this Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, Microsoft.CodeAnalysis.SemanticModel semanticModel, int position, Microsoft.CodeAnalysis.SymbolDisplayFormat format = null)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**position** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**format** &emsp; Microsoft\.CodeAnalysis\.[SymbolDisplayFormat](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.symboldisplayformat)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax)

