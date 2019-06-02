# SymbolExtensions\.HasAttribute Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [HasAttribute(ISymbol, INamedTypeSymbol)](#Roslynator_SymbolExtensions_HasAttribute_Microsoft_CodeAnalysis_ISymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_) | Returns true if the symbol has the specified attribute\. |
| [HasAttribute(ISymbol, MetadataName)](#Roslynator_SymbolExtensions_HasAttribute_Microsoft_CodeAnalysis_ISymbol_Roslynator_MetadataName__) | Returns true if the symbol has attribute with the specified name\. |
| [HasAttribute(ITypeSymbol, INamedTypeSymbol, Boolean)](#Roslynator_SymbolExtensions_HasAttribute_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean_) | Returns true if the type symbol has the specified attribute\. |
| [HasAttribute(ITypeSymbol, MetadataName, Boolean)](#Roslynator_SymbolExtensions_HasAttribute_Microsoft_CodeAnalysis_ITypeSymbol_Roslynator_MetadataName__System_Boolean_) | Returns true if the type symbol has attribute with the specified name\. |

## HasAttribute\(ISymbol, INamedTypeSymbol\) <a name="Roslynator_SymbolExtensions_HasAttribute_Microsoft_CodeAnalysis_ISymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_"></a>

### Summary

Returns true if the symbol has the specified attribute\.

```csharp
public static bool HasAttribute(this Microsoft.CodeAnalysis.ISymbol symbol, Microsoft.CodeAnalysis.INamedTypeSymbol attributeClass)
```

### Parameters

**symbol** &emsp; Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

**attributeClass** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## HasAttribute\(ISymbol, MetadataName\) <a name="Roslynator_SymbolExtensions_HasAttribute_Microsoft_CodeAnalysis_ISymbol_Roslynator_MetadataName__"></a>

### Summary

Returns true if the symbol has attribute with the specified name\.

```csharp
public static bool HasAttribute(this Microsoft.CodeAnalysis.ISymbol symbol, in Roslynator.MetadataName attributeName)
```

### Parameters

**symbol** &emsp; Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)

**attributeName** &emsp; Roslynator\.[MetadataName](../../MetadataName/README.md)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## HasAttribute\(ITypeSymbol, INamedTypeSymbol, Boolean\) <a name="Roslynator_SymbolExtensions_HasAttribute_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean_"></a>

### Summary

Returns true if the type symbol has the specified attribute\.

```csharp
public static bool HasAttribute(this Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, Microsoft.CodeAnalysis.INamedTypeSymbol attributeClass, bool includeBaseTypes)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**attributeClass** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

**includeBaseTypes** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## HasAttribute\(ITypeSymbol, MetadataName, Boolean\) <a name="Roslynator_SymbolExtensions_HasAttribute_Microsoft_CodeAnalysis_ITypeSymbol_Roslynator_MetadataName__System_Boolean_"></a>

### Summary

Returns true if the type symbol has attribute with the specified name\.

```csharp
public static bool HasAttribute(this Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, in Roslynator.MetadataName attributeName, bool includeBaseTypes)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**attributeName** &emsp; Roslynator\.[MetadataName](../../MetadataName/README.md)

**includeBaseTypes** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

