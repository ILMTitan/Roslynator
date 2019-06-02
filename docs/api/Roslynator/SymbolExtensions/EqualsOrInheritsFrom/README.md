# SymbolExtensions\.EqualsOrInheritsFrom Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [EqualsOrInheritsFrom(ITypeSymbol, ITypeSymbol, Boolean)](#Roslynator_SymbolExtensions_EqualsOrInheritsFrom_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_System_Boolean_) | Returns true if the type is equal or inherits from a specified base type\. |
| [EqualsOrInheritsFrom(ITypeSymbol, MetadataName, Boolean)](#Roslynator_SymbolExtensions_EqualsOrInheritsFrom_Microsoft_CodeAnalysis_ITypeSymbol_Roslynator_MetadataName__System_Boolean_) | Returns true if the type is equal or inherits from a type wit the specified name\. |

## EqualsOrInheritsFrom\(ITypeSymbol, ITypeSymbol, Boolean\) <a name="Roslynator_SymbolExtensions_EqualsOrInheritsFrom_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_System_Boolean_"></a>

### Summary

Returns true if the type is equal or inherits from a specified base type\.

```csharp
public static bool EqualsOrInheritsFrom(this Microsoft.CodeAnalysis.ITypeSymbol type, Microsoft.CodeAnalysis.ITypeSymbol baseType, bool includeInterfaces = false)
```

### Parameters

**type** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**baseType** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**includeInterfaces** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## EqualsOrInheritsFrom\(ITypeSymbol, MetadataName, Boolean\) <a name="Roslynator_SymbolExtensions_EqualsOrInheritsFrom_Microsoft_CodeAnalysis_ITypeSymbol_Roslynator_MetadataName__System_Boolean_"></a>

### Summary

Returns true if the type is equal or inherits from a type wit the specified name\.

```csharp
public static bool EqualsOrInheritsFrom(this Microsoft.CodeAnalysis.ITypeSymbol type, in Roslynator.MetadataName baseTypeName, bool includeInterfaces = false)
```

### Parameters

**type** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**baseTypeName** &emsp; Roslynator\.[MetadataName](../../MetadataName/README.md)

**includeInterfaces** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

