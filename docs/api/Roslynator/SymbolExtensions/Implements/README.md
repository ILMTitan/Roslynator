# SymbolExtensions\.Implements Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Implements(ITypeSymbol, INamedTypeSymbol, Boolean)](#Roslynator_SymbolExtensions_Implements_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean_) | Returns true if the type implements specified interface\. |
| [Implements(ITypeSymbol, MetadataName, Boolean)](#Roslynator_SymbolExtensions_Implements_Microsoft_CodeAnalysis_ITypeSymbol_Roslynator_MetadataName__System_Boolean_) | Returns true if the type implements specified interface name\. |
| [Implements(ITypeSymbol, SpecialType, Boolean)](#Roslynator_SymbolExtensions_Implements_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SpecialType_System_Boolean_) | Returns true if the type implements specified interface\. |

## Implements\(ITypeSymbol, INamedTypeSymbol, Boolean\) <a name="Roslynator_SymbolExtensions_Implements_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean_"></a>

### Summary

Returns true if the type implements specified interface\.

```csharp
public static bool Implements(this Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, Microsoft.CodeAnalysis.INamedTypeSymbol interfaceSymbol, bool allInterfaces = false)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**interfaceSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

**allInterfaces** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

If true, use [ITypeSymbol.AllInterfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.allinterfaces), otherwise use [ITypeSymbol.Interfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.interfaces)\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## Implements\(ITypeSymbol, MetadataName, Boolean\) <a name="Roslynator_SymbolExtensions_Implements_Microsoft_CodeAnalysis_ITypeSymbol_Roslynator_MetadataName__System_Boolean_"></a>

### Summary

Returns true if the type implements specified interface name\.

```csharp
public static bool Implements(this Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, in Roslynator.MetadataName interfaceName, bool allInterfaces = false)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**interfaceName** &emsp; Roslynator\.[MetadataName](../../MetadataName/README.md)

**allInterfaces** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## Implements\(ITypeSymbol, SpecialType, Boolean\) <a name="Roslynator_SymbolExtensions_Implements_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_SpecialType_System_Boolean_"></a>

### Summary

Returns true if the type implements specified interface\.

```csharp
public static bool Implements(this Microsoft.CodeAnalysis.ITypeSymbol typeSymbol, Microsoft.CodeAnalysis.SpecialType interfaceType, bool allInterfaces = false)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[ITypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol)

**interfaceType** &emsp; Microsoft\.CodeAnalysis\.[SpecialType](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.specialtype)

**allInterfaces** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

If true, use [ITypeSymbol.AllInterfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.allinterfaces), otherwise use [ITypeSymbol.Interfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.interfaces)\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

