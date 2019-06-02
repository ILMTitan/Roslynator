# SyntaxExtensions\.IsLast\(SyntaxList\<StatementSyntax>, StatementSyntax, Boolean\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns true if the specified statement is a last statement in the list\.

```csharp
public static bool IsLast(this Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax> statements, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax statement, bool ignoreLocalFunctions)
```

### Parameters

**statements** &emsp; Microsoft\.CodeAnalysis\.[SyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\<Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[StatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)>

**statement** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[StatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)

**ignoreLocalFunctions** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

Ignore local function statements at the end of the list\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

