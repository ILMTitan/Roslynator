# Roslynator <img align="left" width="48px" height="48px" src="http://pihrt.net/images/Roslynator.ico">

* A collection of 500+ analyzers, refactorings and fixes for C#, powered by [Roslyn](http://github.com/dotnet/roslyn).
* [List of analyzers](src/Analyzers/README.md)
* [List of refactorings](src/Refactorings/README.md)
* [List of code fixes for CS diagnostics](src/CodeFixes/README.md)
* [Release notes](ChangeLog.md)
* Follow on [Twitter](https://twitter.com/roslynator)

### New Features

* [Fix all diagnostics in a solution](docs/HowToFixAllDiagnostics.md)
* [Generate API documentation](docs/HowToGenerateDocumentation.md)

### Donation

> "It's so good, that I made my first ever donation." Mateusz Piasecki, Roslynator user.

Although Roslynator products are free of charge, any [donation](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=BX85UA346VTN6) is welcome and supports further development.

## Extensions for Visual Studio

| Extension | Comment |
| -------- | ------- |
| [Roslynator 2019](http://marketplace.visualstudio.com/items?itemName=josefpihrt.Roslynator2019) | contains all features - analyzers, refactorings and fixes for CS diagnostics. |
| [Roslynator 2017](http://marketplace.visualstudio.com/items?itemName=josefpihrt.Roslynator2017) | contains all features - analyzers, refactorings and fixes for CS diagnostics. |

*Note: Roslynator for Visual Studio 2015 is no longer in development.*

## NuGet Packages with Analyzers

| Package | Comment |
| -------- | ------- |
| [Roslynator.Analyzers](http://www.nuget.org/packages/Roslynator.Analyzers) &ensp;[![NuGet](https://img.shields.io/nuget/v/Roslynator.Analyzers.svg)](https://nuget.org/packages/Roslynator.Analyzers) | contains only analyzers |

## Roslynator API

* Roslynator API is meant be used for development of your own analyzers/refactorings or other Roslyn-based development.
* It does not contain any analyzers/refactorings itself.
* See [API Reference](docs/api/README.md).

| Package | Built on top of |
| -------- | ------- |
| [Roslynator.Core](http://www.nuget.org/packages/Roslynator.Core) &ensp;[![NuGet](https://img.shields.io/nuget/v/Roslynator.Core.svg)](https://nuget.org/packages/Roslynator.Core) | [Microsoft.CodeAnalysis.Common](http://www.nuget.org/packages/Microsoft.CodeAnalysis.Common) |
| [Roslynator.Workspaces.Core](http://www.nuget.org/packages/Roslynator.Workspaces.Core) &ensp;[![NuGet](https://img.shields.io/nuget/v/Roslynator.Workspaces.Core.svg)](https://nuget.org/packages/Roslynator.Workspaces.Core) | [Microsoft.CodeAnalysis.Workspaces.Common](http://www.nuget.org/packages/Microsoft.CodeAnalysis.Workspaces.Common) |
| [Roslynator.CSharp](http://www.nuget.org/packages/Roslynator.CSharp) &ensp;[![NuGet](https://img.shields.io/nuget/v/Roslynator.CSharp.svg)](https://nuget.org/packages/Roslynator.CSharp) | [Microsoft.CodeAnalysis.CSharp](http://www.nuget.org/packages/Microsoft.CodeAnalysis.CSharp) |
| [Roslynator.CSharp.Workspaces](http://www.nuget.org/packages/Roslynator.CSharp.Workspaces) &ensp;[![NuGet](https://img.shields.io/nuget/v/Roslynator.CSharp.Workspaces.svg)](https://nuget.org/packages/Roslynator.CSharp.Workspaces) | [Microsoft.CodeAnalysis.CSharp.Workspaces](http://www.nuget.org/packages/Microsoft.CodeAnalysis.CSharp.Workspaces) |

## Roslynator Command-Line Interface

* Roslynator CLI is distributed via package [Roslynator.CommandLine](http://www.nuget.org/packages/Roslynator.CommandLine) &ensp;[![NuGet](https://img.shields.io/nuget/v/Roslynator.CommandLine.svg)](https://nuget.org/packages/Roslynator.CommandLine)

* See [documentation](docs/cli/README.md).

## Roslynator for VS Code

Currently VS Code does not support distribution of Roslyn-based tools in an extension.
Also it does not support analyzers at all.
Please read the [tutorial](docs/RoslynatorForVisualStudioCode.md) how to install refactorings and code fixes for CS diagnostics.

## Documentation

* [Analyzers vs. Refactorings](docs/AnalyzersVsRefactorings.md)
* [How to Configure Analyzers](docs/HowToConfigureAnalyzers.md)
* [How to Configure Refactorings](docs/HowToConfigureRefactorings.md)
* [How to Customize Rules for a Project](docs/HowToCustomizeRulesForProject.md)
* [How to Fix All Diagnostics in a Solution](docs/HowToFixAllDiagnostics.md)
* [How to Generate API Documentation](docs/HowToGenerateDocumentation.md)

Would you like to improve Roslynator documentation? Please see [how to update documentation](docs/HowToUpdateDocumentation.md).

## Other Projects

* [Snippetica](https://github.com/JosefPihrt/Snippetica) - A collection of snippets for C++, C#, HTML, JSON, Markdown, VB, XAML and XML
* [DotMarkdown](https://github.com/JosefPihrt/DotMarkdown) - Markdown framework for .NET
* [LINQ to Regex](https://github.com/JosefPihrt/LinqToRegex) - A library that provides language integrated access to .NET regular expressions
* [Snippet Manager](https://github.com/JosefPihrt/SnippetManager) - A library that enables to work with Visual Studio snippets
* [Regexator](http://pihrt.net/Regexator) - A comprehensive development environment for .NET regular expressions
