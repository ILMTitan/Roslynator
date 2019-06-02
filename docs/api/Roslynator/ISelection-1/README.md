# ISelection\<T> Interface

[Home](../../README.md) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Roslynator](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Represents consecutive sequence of selected items in a collection\.

```csharp
public interface ISelection<T> : System.Collections.Generic.IReadOnlyList<T>
```

### Type Parameters

**T**

### Derived

* Roslynator\.[SeparatedSyntaxListSelection\<TNode>](../SeparatedSyntaxListSelection-1/README.md)
* Roslynator\.[SyntaxListSelection\<TNode>](../SyntaxListSelection-1/README.md)
* Roslynator\.Text\.[TextLineCollectionSelection](../Text/TextLineCollectionSelection/README.md)

### Implements

* System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<T>
* System\.Collections\.Generic\.[IReadOnlyCollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1)\<T>
* System\.Collections\.Generic\.[IReadOnlyList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)\<T>

## Properties

| Property | Summary |
| -------- | ------- |
| [FirstIndex](FirstIndex/README.md) | Gets an index of the first selected item\. |
| [LastIndex](LastIndex/README.md) | Gets an index of the last selected item\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [First()](First/README.md) | Gets the first selected item\. |
| [Last()](Last/README.md) | Gets the last selected item\. |

