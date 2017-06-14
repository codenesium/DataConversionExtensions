# DataConversionExtensions

## C# library of extension methods for converting data 

```
Install-Package Codenesium.DataConversionExtensions
```


To convert a string and return a 0 if it's can't be converted into an int.
```
var aString = "123";
int result = Convert.ToInt32(aString); //result will be 123
```

```
var aString = "NaN";
int result = Convert.ToInt32(aString); //result will be 0
```


If you want to return a null if it can't be converted into an int.
```
var aString = "123";
int? result = aString.ToNullableInt(); //result will be 123
```

```
var aString = "NaN";
int? result = aString.ToNullableInt(); //result will be null
```

This same strategy is applied to int, decimal, long, guid, boolean datetime etc.