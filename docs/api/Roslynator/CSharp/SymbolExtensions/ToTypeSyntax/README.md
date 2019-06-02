# SymbolExtensions\.ToTypeSyntax Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ToTypeSyntax(INamespaceOrTypeSymbol, SymbolDisplayFormat)](#Roslynator_CSharp_SymbolExtensions_ToTypeSyntax_Microsoft_CodeAnalysis_INamespaceOrTypeSymbol_Microsoft_CodeAnalysis_SymbolDisplayFormat_) | Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified namespace or type symbol\. |
| [ToTypeSyntax(INamespaceSymbol, SymbolDisplayFormat)](#Roslynator_CSharp_SymbolExtensions_ToTypeSyntax_Microsoft_CodeAnalysis_INamespaceSymbol_Microsoft_CodeAnalysis_SymbolDisplayFormat_) | Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified namespace symbol\. |
| [ToTypeSyntax(ITypeSymbol, SymbolDisplayFormat)](#Roslynator_CSharp_SymbolExtensions_ToTypeSyntax_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SymbolDisplayFormat_) | Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified type symbol\. |

## ToTypeSyntax\(INamespaceOrTypeSymbol, SymbolDisplayFormat\) <a name="Roslynator_CSharp_SymbolExtensions_ToTypeSyntax_Microsoft_CodeAnalysis_INamespaceOrTypeSymbol_Microsoft_CodeAnalysis_SymbolDisplayFormat_"></a>

### Summary

Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified namespace or type symbol\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax ToTypeSyntax(this Microsoft.CodeAnalysis.INamespaceOrTypeSymbol namespaceOrTypeSymbol, Microsoft.CodeAnalysis.SymbolDisplayFormat format = null)
```

### Parameters

**namespaceOrTypeSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamespaceOrTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamespaceortypesymbol)

**format** &emsp; Microsoft\.CodeAnalysis\.[SymbolDisplayFormat](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.symboldisplayformat)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax)

## ToTypeSyntax\(INamespaceSymbol, SymbolDisplayFormat\) <a name="Roslynator_CSharp_SymbolExtensions_ToTypeSyntax_Microsoft_CodeAnalysis_INamespaceSymbol_Microsoft_CodeAnalysis_SymbolDisplayFormat_"></a>

### Summary

Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified namespace symbol\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax ToTypeSyntax(this Microsoft.CodeAnalysis.INamespaceSymbol namespaceSymbol, Microsoft.CodeAnalysis.SymbolDisplayFormat format = null)
```

### Parameters

**namespaceSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamespaceSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamespacesymbol)

**format** &emsp; Microsoft\.CodeAnalysis\.[SymbolDisplayFormat](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.symboldisplayformat)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax)

## ToTypeSyntax\(ITypeSymbol, SymbolDisplayFormat\) <a name="Roslynator_CSharp_SymbolExtensions_ToTypeSyntax_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SymbolDisplayFormat_"></a>

### Summary

Creates a new [TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax) based on the specified type symbol\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax ToTypeSyntax(this Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, Microsoft.CodeAnalysis.SymbolDisplayFormat format = null)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**format** &emsp; Microsoft\.CodeAnalysis\.[SymbolDisplayFormat](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.symboldisplayformat)

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[TypeSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typesyntax)

