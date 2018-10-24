# PerformanceLab.IsNumber

## The faster way to check if string is number

Results for 5 000 000 checks:

| Method        | Time          | 
| ------------- |:-------------:| 
| Custom        | 364ms         | 
| int.TryParse  | 5930ms        | 
| int.Parse     | Super slow    | 


### Custom method

```csharp
public static bool IsNumber(string numberAsString)
{
    foreach (var c in numberAsString)
    {
        if (c < '0' || c > '9')
        {
            return false;
        }
    }

    return true;
}
```
