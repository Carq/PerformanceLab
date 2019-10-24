# PerformanceLab.IsEmpty

## The faster way to check if list if empty

Results for **2 147 483 647** checks for List with 20000 elements:

| Method     |       Time        |
| ---------- | :---------------: |
| Count == 0 | 14 697 ms (~14s)  |
| Any()      | 123 660ms (~123s) |

Results for **20000** checks for IEnumerable with 20000 elements:

| Method       |      Time       |
| ------------ | :-------------: |
| Any()        |      15ms       |
| Count() == 0 | 85 690ms (~85s) |

### Methods

```csharp
private static bool CountTestMethod(IList<string> collectionToTest)
{
    return collectionToTest.Count == 0;
}

private static bool AnyTestMethod(IList<string> collectionToTest)
{
    return !collectionToTest.Any();
}

private static bool CountTestMethod(IEnumerable<string> collectionToTest)
{
    return collectionToTest.Count() == 0;
}

private static bool AnyTestMethod(IEnumerable<string> collectionToTest)
{
    return !collectionToTest.Any();
}
```
