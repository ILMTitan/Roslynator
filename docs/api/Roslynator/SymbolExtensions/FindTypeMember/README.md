# SymbolExtensions\.FindTypeMember Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [FindTypeMember(INamedTypeSymbol, Func\<INamedTypeSymbol, Boolean>, Boolean)](#Roslynator_SymbolExtensions_FindTypeMember_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Func_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean__System_Boolean_) | Searches for a type member that matches the conditions defined by the specified predicate and returns the first occurrence within the type's members\. |
| [FindTypeMember(INamedTypeSymbol, String, Func\<INamedTypeSymbol, Boolean>, Boolean)](#Roslynator_SymbolExtensions_FindTypeMember_Microsoft_CodeAnalysis_INamedTypeSymbol_System_String_System_Func_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean__System_Boolean_) | Searches for a type member that has the specified name and matches the conditions defined by the specified predicate, if any, and returns the first occurrence within the type's members\. |
| [FindTypeMember(INamedTypeSymbol, String, Int32, Func\<INamedTypeSymbol, Boolean>, Boolean)](#Roslynator_SymbolExtensions_FindTypeMember_Microsoft_CodeAnalysis_INamedTypeSymbol_System_String_System_Int32_System_Func_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean__System_Boolean_) | Searches for a type member that has the specified name, arity and matches the conditions defined by the specified predicate, if any, and returns the first occurrence within the type's members\. |

## FindTypeMember\(INamedTypeSymbol, Func\<INamedTypeSymbol, Boolean>, Boolean\) <a name="Roslynator_SymbolExtensions_FindTypeMember_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Func_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean__System_Boolean_"></a>

### Summary

Searches for a type member that matches the conditions defined by the specified predicate and returns the first occurrence within the type's members\.

```csharp
public static Microsoft.CodeAnalysis.INamedTypeSymbol FindTypeMember(this Microsoft.CodeAnalysis.INamedTypeSymbol typeSymbol, Func<Microsoft.CodeAnalysis.INamedTypeSymbol, bool> predicate, bool includeBaseTypes = false)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

**includeBaseTypes** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

## FindTypeMember\(INamedTypeSymbol, String, Func\<INamedTypeSymbol, Boolean>, Boolean\) <a name="Roslynator_SymbolExtensions_FindTypeMember_Microsoft_CodeAnalysis_INamedTypeSymbol_System_String_System_Func_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean__System_Boolean_"></a>

### Summary

Searches for a type member that has the specified name and matches the conditions defined by the specified predicate, if any, and returns the first occurrence within the type's members\.

```csharp
public static Microsoft.CodeAnalysis.INamedTypeSymbol FindTypeMember(this Microsoft.CodeAnalysis.INamedTypeSymbol typeSymbol, string name, Func<Microsoft.CodeAnalysis.INamedTypeSymbol, bool> predicate = null, bool includeBaseTypes = false)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

**name** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

**includeBaseTypes** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

## FindTypeMember\(INamedTypeSymbol, String, Int32, Func\<INamedTypeSymbol, Boolean>, Boolean\) <a name="Roslynator_SymbolExtensions_FindTypeMember_Microsoft_CodeAnalysis_INamedTypeSymbol_System_String_System_Int32_System_Func_Microsoft_CodeAnalysis_INamedTypeSymbol_System_Boolean__System_Boolean_"></a>

### Summary

Searches for a type member that has the specified name, arity and matches the conditions defined by the specified predicate, if any, and returns the first occurrence within the type's members\.

```csharp
public static Microsoft.CodeAnalysis.INamedTypeSymbol FindTypeMember(this Microsoft.CodeAnalysis.INamedTypeSymbol typeSymbol, string name, int arity, Func<Microsoft.CodeAnalysis.INamedTypeSymbol, bool> predicate = null, bool includeBaseTypes = false)
```

### Parameters

**typeSymbol** &emsp; Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

**name** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**arity** &emsp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**predicate** &emsp; [Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)>

**includeBaseTypes** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Microsoft\.CodeAnalysis\.[INamedTypeSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

