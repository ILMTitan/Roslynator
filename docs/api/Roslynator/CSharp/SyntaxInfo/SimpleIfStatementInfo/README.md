# SyntaxInfo\.SimpleIfStatementInfo Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SimpleIfStatementInfo(IfStatementSyntax, Boolean, Boolean)](#Roslynator_CSharp_SyntaxInfo_SimpleIfStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IfStatementSyntax_System_Boolean_System_Boolean_) | Creates a new [SimpleIfStatementInfo](../../Syntax/SimpleIfStatementInfo/README.md) from the specified if statement\. |
| [SimpleIfStatementInfo(SyntaxNode, Boolean, Boolean)](#Roslynator_CSharp_SyntaxInfo_SimpleIfStatementInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_System_Boolean_) | Creates a new [SimpleIfStatementInfo](../../Syntax/SimpleIfStatementInfo/README.md) from the specified node\. |

## SimpleIfStatementInfo\(IfStatementSyntax, Boolean, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_SimpleIfStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_IfStatementSyntax_System_Boolean_System_Boolean_"></a>

### Summary

Creates a new [SimpleIfStatementInfo](../../Syntax/SimpleIfStatementInfo/README.md) from the specified if statement\.

```csharp
public static Roslynator.CSharp.Syntax.SimpleIfStatementInfo SimpleIfStatementInfo(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax ifStatement, bool walkDownParentheses = true, bool allowMissing = false)
```

### Parameters

**ifStatement** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[IfStatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.ifstatementsyntax)

**walkDownParentheses** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**allowMissing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Roslynator\.CSharp\.Syntax\.[SimpleIfStatementInfo](../../Syntax/SimpleIfStatementInfo/README.md)

## SimpleIfStatementInfo\(SyntaxNode, Boolean, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_SimpleIfStatementInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_System_Boolean_"></a>

### Summary

Creates a new [SimpleIfStatementInfo](../../Syntax/SimpleIfStatementInfo/README.md) from the specified node\.

```csharp
public static Roslynator.CSharp.Syntax.SimpleIfStatementInfo SimpleIfStatementInfo(Microsoft.CodeAnalysis.SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false)
```

### Parameters

**node** &emsp; Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

**walkDownParentheses** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**allowMissing** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

Roslynator\.CSharp\.Syntax\.[SimpleIfStatementInfo](../../Syntax/SimpleIfStatementInfo/README.md)

