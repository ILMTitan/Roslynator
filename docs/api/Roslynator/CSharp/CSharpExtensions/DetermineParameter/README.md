# CSharpExtensions\.DetermineParameter Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[CSharpExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [DetermineParameter(SemanticModel, ArgumentSyntax, Boolean, Boolean, CancellationToken)](#Roslynator_CSharp_CSharpExtensions_DetermineParameter_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_ArgumentSyntax_System_Boolean_System_Boolean_System_Threading_CancellationToken_) | Determines a parameter symbol that matches to the specified argument\. Returns null if no matching parameter is found\. |
| [DetermineParameter(SemanticModel, AttributeArgumentSyntax, Boolean, Boolean, CancellationToken)](#Roslynator_CSharp_CSharpExtensions_DetermineParameter_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_AttributeArgumentSyntax_System_Boolean_System_Boolean_System_Threading_CancellationToken_) | Determines a parameter symbol that matches to the specified attribute argument\. Returns null if not matching parameter is found\. |

## DetermineParameter\(SemanticModel, ArgumentSyntax, Boolean, Boolean, CancellationToken\) <a name="Roslynator_CSharp_CSharpExtensions_DetermineParameter_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_ArgumentSyntax_System_Boolean_System_Boolean_System_Threading_CancellationToken_"></a>

### Summary

Determines a parameter symbol that matches to the specified argument\.
Returns null if no matching parameter is found\.

```csharp
public static Microsoft.CodeAnalysis.IParameterSymbol DetermineParameter(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax argument, bool allowParams = false, bool allowCandidate = false, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**argument** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ArgumentSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.argumentsyntax)

**allowParams** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**allowCandidate** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Microsoft\.CodeAnalysis\.[IParameterSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.iparametersymbol)

## DetermineParameter\(SemanticModel, AttributeArgumentSyntax, Boolean, Boolean, CancellationToken\) <a name="Roslynator_CSharp_CSharpExtensions_DetermineParameter_Microsoft_CodeAnalysis_SemanticModel_Microsoft_CodeAnalysis_CSharp_Syntax_AttributeArgumentSyntax_System_Boolean_System_Boolean_System_Threading_CancellationToken_"></a>

### Summary

Determines a parameter symbol that matches to the specified attribute argument\.
Returns null if not matching parameter is found\.

```csharp
public static Microsoft.CodeAnalysis.IParameterSymbol DetermineParameter(this Microsoft.CodeAnalysis.SemanticModel semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax attributeArgument, bool allowParams = false, bool allowCandidate = false, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**semanticModel** &emsp; Microsoft\.CodeAnalysis\.[SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)

**attributeArgument** &emsp; Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AttributeArgumentSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.attributeargumentsyntax)

**allowParams** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**allowCandidate** &emsp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**cancellationToken** &emsp; System\.Threading\.[CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

Microsoft\.CodeAnalysis\.[IParameterSymbol](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.iparametersymbol)

