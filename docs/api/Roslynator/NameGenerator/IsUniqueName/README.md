# NameGenerator\.IsUniqueName Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[NameGenerator](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IsUniqueName(String, IEnumerable\<String>, Boolean)](#Roslynator_NameGenerator_IsUniqueName_System_String_System_Collections_Generic_IEnumerable_System_String__System_Boolean_) | Returns true if the name is not contained in the specified list\. |
| [IsUniqueName(String, ImmutableArray\<ISymbol>, Boolean)](#Roslynator_NameGenerator_IsUniqueName_System_String_System_Collections_Immutable_ImmutableArray_Microsoft_CodeAnalysis_ISymbol__System_Boolean_) | Returns true if the name is not contained in the specified list\. [ISymbol.Name](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol.name) is used to compare names\. |

## IsUniqueName\(String, IEnumerable\<String>, Boolean\) <a name="Roslynator_NameGenerator_IsUniqueName_System_String_System_Collections_Generic_IEnumerable_System_String__System_Boolean_"></a>

### Summary

Returns true if the name is not contained in the specified list\.

```csharp
public static bool IsUniqueName(string name, System.Collections.Generic.IEnumerable<string> reservedNames, bool isCaseSensitive = true)
```

### Parameters

**name** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**reservedNames** &emsp; System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)>

**isCaseSensitive** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsUniqueName\(String, ImmutableArray\<ISymbol>, Boolean\) <a name="Roslynator_NameGenerator_IsUniqueName_System_String_System_Collections_Immutable_ImmutableArray_Microsoft_CodeAnalysis_ISymbol__System_Boolean_"></a>

### Summary

Returns true if the name is not contained in the specified list\. [ISymbol.Name](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol.name) is used to compare names\.

```csharp
public static bool IsUniqueName(string name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol> symbols, bool isCaseSensitive = true)
```

### Parameters

**name** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**symbols** &emsp; System\.Collections\.Immutable\.[ImmutableArray](https://docs.microsoft.com/en-us/dotnet/api/system.collections.immutable.immutablearray-1)\<Microsoft\.CodeAnalysis\.[ISymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol)>

**isCaseSensitive** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

