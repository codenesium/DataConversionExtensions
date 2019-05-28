# DataConversionExtensions

## C# library of extension methods for converting data 

```
Install-Package Codenesium.DataConversionExtensions.AspNetCore
```

[![NuGet Badge](https://buildstats.info/nuget/Codenesium.DataConversionExtensions)](https://www.nuget.org/packages/Codenesium.DataConversionExtensions/)


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


String Extensions
```
bool ToBoolean(this string obj)
bool? ToNullableBoolean(this string obj)
Datetime ToDatetime(this string obj)
DateTime? ToNullableDatetime(this string obj)
DateTimeOffset ToDateTimeOffset(this string obj)
DateTimeOffset? ToNullableDateTimeOffset(this string obj)
decimal ToDecimal(this string obj)
decimal? ToNullableDecimal(this string obj)
float ToFloat(this string obj)
float? ToNullableFloat(this string obj)
Guid ToGuid(this string obj)
Guid? ToNullableGuid(this string obj)
int ToInt(this string obj)
int? ToNullableInt(this string obj)
long ToLong(this string obj)
long? ToNullableLong(this string obj)
short ToShort(this string obj)
short? ToNullableShort(this string obj)
TimeSpan ToTimeSpan(this string obj)
TimeSpan? ToNullableTimeSpan(this string obj)
```

Object Extensions
```
string ContentToString(this HttpContent httpContent)
Nullable<int> GetNullableKey(this object obj)
int GetKey(this object obj)
string ToJSONString(this object obj)
bool IsEmptyOrZeroOrNull(this object obj)
```

HttpResponseMessage Extensions
```
HttpResponseMessage ToJSONResponse(this object obj, System.Net.HttpStatusCode statusCode)
string GetHeaderValue(this HttpResponseMessage message, string key)
```
