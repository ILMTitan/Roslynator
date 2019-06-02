# MemberDeclarationListSelection\.TryCreate Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[MemberDeclarationListSelection](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [TryCreate(NamespaceDeclarationSyntax, TextSpan, MemberDeclarationListSelection)](#Roslynator_CSharp_MemberDeclarationListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_MemberDeclarationListSelection__) | Creates a new [MemberDeclarationListSelection](../README.md) based on the specified namespace declaration and span\. |
| [TryCreate(TypeDeclarationSyntax, TextSpan, MemberDeclarationListSelection)](#Roslynator_CSharp_MemberDeclarationListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_TypeDeclarationSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_MemberDeclarationListSelection__) | Creates a new [MemberDeclarationListSelection](../README.md) based on the specified type declaration and span\. |

## TryCreate\(NamespaceDeclarationSyntax, TextSpan, MemberDeclarationListSelection\) <a name="Roslynator_CSharp_MemberDeclarationListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_MemberDeclarationListSelection__"></a>

### Summary

Creates a new [MemberDeclarationListSelection](../README.md) based on the specified namespace declaration and span\.

```csharp
public static bool TryCreate(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax namespaceDeclaration, Microsoft.CodeAnalysis.Text.TextSpan span, out Roslynator.CSharp.MemberDeclarationListSelection selectedMembers)
```

### Parameters

**namespaceDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

**selectedMembers** &emsp; Roslynator\.CSharp\.[MemberDeclarationListSelection](../README.md)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

True if the specified span contains at least one member; otherwise, false\.

## TryCreate\(TypeDeclarationSyntax, TextSpan, MemberDeclarationListSelection\) <a name="Roslynator_CSharp_MemberDeclarationListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_TypeDeclarationSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_MemberDeclarationListSelection__"></a>

### Summary

Creates a new [MemberDeclarationListSelection](../README.md) based on the specified type declaration and span\.

```csharp
public static bool TryCreate(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax typeDeclaration, Microsoft.CodeAnalysis.Text.TextSpan span, out Roslynator.CSharp.MemberDeclarationListSelection selectedMembers)
```

### Parameters

**typeDeclaration** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[TypeDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.typedeclarationsyntax)

**span** &emsp; Microsoft\.CodeAnalysis\.Text\.[TextSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.text.textspan)

**selectedMembers** &emsp; Roslynator\.CSharp\.[MemberDeclarationListSelection](../README.md)

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

True if the specified span contains at least one member; otherwise, false\.