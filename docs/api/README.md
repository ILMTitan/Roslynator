# Roslynator API Reference

[Namespaces](#namespaces) &#x2022; [Class Hierarchy](#class-hierarchy) &#x2022; [Other](#other)

## Namespaces

* [Roslynator](Roslynator/README.md)
* [Roslynator.CSharp](Roslynator/CSharp/README.md)
* [Roslynator.CSharp.Syntax](Roslynator/CSharp/Syntax/README.md)
* [Roslynator.Text](Roslynator/Text/README.md)

## Class Hierarchy

* \([Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\)<a id="System_Object"></a>
* &emsp; \([EqualityComparer\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.equalitycomparer-1)\)<a id="System_Collections_Generic_EqualityComparer_1"></a>
* &emsp; [&bull;](#System_Collections_Generic_EqualityComparer_1 "EqualityComparer<T>") &emsp; [MetadataNameEqualityComparer\<TSymbol>](Roslynator/MetadataNameEqualityComparer-1/README.md)<a id="Roslynator_MetadataNameEqualityComparer_1"></a>
* &emsp; [ModifierList\<TNode>](Roslynator/CSharp/ModifierList-1/README.md)<a id="Roslynator_CSharp_ModifierList_1"></a>
* &emsp; [NameGenerator](Roslynator/NameGenerator/README.md)<a id="Roslynator_NameGenerator"></a>
* &emsp; [SeparatedSyntaxListSelection\<TNode>](Roslynator/SeparatedSyntaxListSelection-1/README.md)<a id="Roslynator_SeparatedSyntaxListSelection_1"></a>
* &emsp; [SyntaxListSelection\<TNode>](Roslynator/SyntaxListSelection-1/README.md)<a id="Roslynator_SyntaxListSelection_1"></a>
* &emsp; [&bull;](#Roslynator_SyntaxListSelection_1 "SyntaxListSelection<TNode>") &emsp; [MemberDeclarationListSelection](Roslynator/CSharp/MemberDeclarationListSelection/README.md)<a id="Roslynator_CSharp_MemberDeclarationListSelection"></a>
* &emsp; [&bull;](#Roslynator_SyntaxListSelection_1 "SyntaxListSelection<TNode>") &emsp; [StatementListSelection](Roslynator/CSharp/StatementListSelection/README.md)<a id="Roslynator_CSharp_StatementListSelection"></a>
* &emsp; [TextLineCollectionSelection](Roslynator/Text/TextLineCollectionSelection/README.md)<a id="Roslynator_Text_TextLineCollectionSelection"></a>

## [Roslynator](Roslynator/README.md) Namespace

### Classes

* [DiagnosticsExtensions](Roslynator/DiagnosticsExtensions/README.md)
* [EnumExtensions](Roslynator/EnumExtensions/README.md)
* [FileLinePositionSpanExtensions](Roslynator/FileLinePositionSpanExtensions/README.md)
* [MetadataNameEqualityComparer\<TSymbol>](Roslynator/MetadataNameEqualityComparer-1/README.md)
* [NameGenerator](Roslynator/NameGenerator/README.md)
* [SemanticModelExtensions](Roslynator/SemanticModelExtensions/README.md)
* [SeparatedSyntaxListSelection\<TNode>](Roslynator/SeparatedSyntaxListSelection-1/README.md)
* [SymbolExtensions](Roslynator/SymbolExtensions/README.md)
* [SyntaxExtensions](Roslynator/SyntaxExtensions/README.md)
* [SyntaxListSelection\<TNode>](Roslynator/SyntaxListSelection-1/README.md)
* [SyntaxTreeExtensions](Roslynator/SyntaxTreeExtensions/README.md)
* [WorkspaceExtensions](Roslynator/WorkspaceExtensions/README.md)

### Structs

* [ExtensionMethodSymbolInfo](Roslynator/ExtensionMethodSymbolInfo/README.md)
* [MetadataName](Roslynator/MetadataName/README.md)
* [SeparatedSyntaxListSelection\<TNode>.Enumerator](Roslynator/SeparatedSyntaxListSelection-1/Enumerator/README.md)
* [SyntaxListSelection\<TNode>.Enumerator](Roslynator/SyntaxListSelection-1/Enumerator/README.md)

### Interfaces

* [ISelection\<T>](Roslynator/ISelection-1/README.md)

### Enums

* [Visibility](Roslynator/Visibility/README.md)

## [Roslynator.CSharp](Roslynator/CSharp/README.md) Namespace

### Classes

* [CSharpExtensions](Roslynator/CSharp/CSharpExtensions/README.md)
* [CSharpFactory](Roslynator/CSharp/CSharpFactory/README.md)
* [CSharpFacts](Roslynator/CSharp/CSharpFacts/README.md)
* [MemberDeclarationListSelection](Roslynator/CSharp/MemberDeclarationListSelection/README.md)
* [ModifierList](Roslynator/CSharp/ModifierList/README.md)
* [ModifierList\<TNode>](Roslynator/CSharp/ModifierList-1/README.md)
* [Modifiers](Roslynator/CSharp/Modifiers/README.md)
* [StatementListSelection](Roslynator/CSharp/StatementListSelection/README.md)
* [SymbolExtensions](Roslynator/CSharp/SymbolExtensions/README.md)
* [SyntaxAccessibility](Roslynator/CSharp/SyntaxAccessibility/README.md)
* [SyntaxExtensions](Roslynator/CSharp/SyntaxExtensions/README.md)
* [SyntaxInfo](Roslynator/CSharp/SyntaxInfo/README.md)
* [SyntaxInverter](Roslynator/CSharp/SyntaxInverter/README.md)
* [WorkspaceExtensions](Roslynator/CSharp/WorkspaceExtensions/README.md)
* [WorkspaceSyntaxExtensions](Roslynator/CSharp/WorkspaceSyntaxExtensions/README.md)

### Structs

* [ExpressionChain](Roslynator/CSharp/ExpressionChain/README.md)
* [ExpressionChain.Enumerator](Roslynator/CSharp/ExpressionChain/Enumerator/README.md)
* [ExpressionChain.Reversed](Roslynator/CSharp/ExpressionChain/Reversed/README.md)
* [ExpressionChain.Reversed.Enumerator](Roslynator/CSharp/ExpressionChain/Reversed/Enumerator/README.md)
* [IfStatementCascade](Roslynator/CSharp/IfStatementCascade/README.md)
* [IfStatementCascade.Enumerator](Roslynator/CSharp/IfStatementCascade/Enumerator/README.md)
* [IfStatementCascadeInfo](Roslynator/CSharp/IfStatementCascadeInfo/README.md)
* [IfStatementOrElseClause](Roslynator/CSharp/IfStatementOrElseClause/README.md)

### Enums

* [CommentFilter](Roslynator/CSharp/CommentFilter/README.md)
* [ModifierFilter](Roslynator/CSharp/ModifierFilter/README.md)
* [NullCheckStyles](Roslynator/CSharp/NullCheckStyles/README.md)
* [PreprocessorDirectiveFilter](Roslynator/CSharp/PreprocessorDirectiveFilter/README.md)

## [Roslynator.CSharp.Syntax](Roslynator/CSharp/Syntax/README.md) Namespace

### Structs

* [AsExpressionInfo](Roslynator/CSharp/Syntax/AsExpressionInfo/README.md)
* [AssignmentExpressionInfo](Roslynator/CSharp/Syntax/AssignmentExpressionInfo/README.md)
* [BinaryExpressionInfo](Roslynator/CSharp/Syntax/BinaryExpressionInfo/README.md)
* [ConditionalExpressionInfo](Roslynator/CSharp/Syntax/ConditionalExpressionInfo/README.md)
* [GenericInfo](Roslynator/CSharp/Syntax/GenericInfo/README.md)
* [IsExpressionInfo](Roslynator/CSharp/Syntax/IsExpressionInfo/README.md)
* [LocalDeclarationStatementInfo](Roslynator/CSharp/Syntax/LocalDeclarationStatementInfo/README.md)
* [MemberDeclarationListInfo](Roslynator/CSharp/Syntax/MemberDeclarationListInfo/README.md)
* [ModifierListInfo](Roslynator/CSharp/Syntax/ModifierListInfo/README.md)
* [NullCheckExpressionInfo](Roslynator/CSharp/Syntax/NullCheckExpressionInfo/README.md)
* [RegionInfo](Roslynator/CSharp/Syntax/RegionInfo/README.md)
* [SimpleAssignmentExpressionInfo](Roslynator/CSharp/Syntax/SimpleAssignmentExpressionInfo/README.md)
* [SimpleAssignmentStatementInfo](Roslynator/CSharp/Syntax/SimpleAssignmentStatementInfo/README.md)
* [SimpleIfStatementInfo](Roslynator/CSharp/Syntax/SimpleIfStatementInfo/README.md)
* [SimpleMemberInvocationExpressionInfo](Roslynator/CSharp/Syntax/SimpleMemberInvocationExpressionInfo/README.md)
* [SimpleMemberInvocationStatementInfo](Roslynator/CSharp/Syntax/SimpleMemberInvocationStatementInfo/README.md)
* [SingleLocalDeclarationStatementInfo](Roslynator/CSharp/Syntax/SingleLocalDeclarationStatementInfo/README.md)
* [SingleParameterLambdaExpressionInfo](Roslynator/CSharp/Syntax/SingleParameterLambdaExpressionInfo/README.md)
* [StatementListInfo](Roslynator/CSharp/Syntax/StatementListInfo/README.md)
* [StringConcatenationExpressionInfo](Roslynator/CSharp/Syntax/StringConcatenationExpressionInfo/README.md)
* [StringLiteralExpressionInfo](Roslynator/CSharp/Syntax/StringLiteralExpressionInfo/README.md)
* [UsingDirectiveListInfo](Roslynator/CSharp/Syntax/UsingDirectiveListInfo/README.md)
* [XmlElementInfo](Roslynator/CSharp/Syntax/XmlElementInfo/README.md)

## [Roslynator.Text](Roslynator/Text/README.md) Namespace

### Classes

* [TextLineCollectionSelection](Roslynator/Text/TextLineCollectionSelection/README.md)

### Structs

* [TextLineCollectionSelection.Enumerator](Roslynator/Text/TextLineCollectionSelection/Enumerator/README.md)

## Other

* [Extensions of External Types](_Extensions.md)
