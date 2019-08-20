# PerformanceLab.IsEmpty

## The faster way to check if list if empty

Results for **2 147 483 647** checks for List with 20000 elements:

| Method     |  Time  |
| ---------- | :----: |
| Any()      | 7704ms |
| Count == 0 | 7705ms |

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
```
