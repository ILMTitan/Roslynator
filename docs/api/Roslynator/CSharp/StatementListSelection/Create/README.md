# StatementListSelection\.Create Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[StatementListSelection](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Create(BlockSyntax, TextSpan)](#Roslynator_CSharp_StatementListSelection_Create_Microsoft_CodeAnalysis_CSharp_Syntax_BlockSyntax_Microsoft_CodeAnalysis_Text_TextSpan_) | Creates a new [StatementListSelection](../README.md) based on the specified block and span\. |
| [Create(StatementListInfo, TextSpan)](#Roslynator_CSharp_StatementListSelection_Create_Roslynator_CSharp_Syntax_StatementListInfo__Microsoft_CodeAnalysis_Text_TextSpan_) | Creates a new [StatementListSelection](../README.md) based on the specified [StatementListInfo](../../Syntax/StatementListInfo/README.md) and span\. |
| [Create(SwitchSectionSyntax, TextSpan)](#Roslynator_CSharp_StatementListSelection_Create_Microsoft_CodeAnalysis_CSharp_Syntax_SwitchSectionSyntax_Microsoft_CodeAnalysis_Text_TextSpan_) | Creates a new [StatementListSelection](../README.md) based on the specified switch section and span\. |

## Create\(BlockSyntax, TextSpan\) <a name="Roslynator_CSharp_StatementListSelection_Create_Microsoft_CodeAnalysis_CSharp_Syntax_BlockSyntax_Microsoft_CodeAnalysis_Text_TextSpan_"></a>

### Summary

Creates a new [StatementListSelection](../README.md) based on the specified block and span\.

```csharp
public static Roslynator.CSharp.StatementListSelection Create(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax block, Microsoft.CodeAnalysis.Text.TextSpan span)
```

### Parameters

**block** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[BlockSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.blocksyntax)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

### Returns

Roslynator\.CSharp\.[StatementListSelection](../README.md)

## Create\(StatementListInfo, TextSpan\) <a name="Roslynator_CSharp_StatementListSelection_Create_Roslynator_CSharp_Syntax_StatementListInfo__Microsoft_CodeAnalysis_Text_TextSpan_"></a>

### Summary

Creates a new [StatementListSelection](../README.md) based on the specified [StatementListInfo](../../Syntax/StatementListInfo/README.md) and span\.

```csharp
public static Roslynator.CSharp.StatementListSelection Create(in Roslynator.CSharp.Syntax.StatementListInfo statementsInfo, Microsoft.CodeAnalysis.Text.TextSpan span)
```

### Parameters

**statementsInfo** &emsp; Roslynator\.CSharp\.Syntax\.[StatementListInfo](../../Syntax/StatementListInfo/README.md)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

### Returns

Roslynator\.CSharp\.[StatementListSelection](../README.md)

## Create\(SwitchSectionSyntax, TextSpan\) <a name="Roslynator_CSharp_StatementListSelection_Create_Microsoft_CodeAnalysis_CSharp_Syntax_SwitchSectionSyntax_Microsoft_CodeAnalysis_Text_TextSpan_"></a>

### Summary

Creates a new [StatementListSelection](../README.md) based on the specified switch section and span\.

```csharp
public static Roslynator.CSharp.StatementListSelection Create(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax switchSection, Microsoft.CodeAnalysis.Text.TextSpan span)
```

### Parameters

**switchSection** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[SwitchSectionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.switchsectionsyntax)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

### Returns

Roslynator\.CSharp\.[StatementListSelection](../README.md)

