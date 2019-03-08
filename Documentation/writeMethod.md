# Write data

## NOTE

Pay attention to the scope line, it needs to be this way:

```C#
static string[] Scopes = { SheetsService.Scope.Spreadsheets};
```
Otherwise, writing will not be done.

Generical necessary params:

```C#
String spreadsheetId = "YOUR SPREADSHEET ID";
String range = "YOUR SPREADSHEET RANGE";
```

## Append method

### Values *do not* override

The values ​​should be passed by parameter as follows:

```C#
var oblist = new List<object>() { "value 1", "Value 2", "Value 3"};
```

The append method is:

```C#
SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum valueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;

ValueRange requestBody = new ValueRange();

var oblist = new List<object>() { "YOUR SPREADSHEET VALUE" };
requestBody.Values = new List<IList<object>> { oblist };

SpreadsheetsResource.ValuesResource.AppendRequest request = sheetsService.Spreadsheets.Values.Append(requestBody, spreadsheetId, range);
request.ValueInputOption = valueInputOption;

AppendValuesResponse response = request.Execute();
```

## Update method

### ### Values are *overridden*

The values ​​should be passed by parameter as follows:

```C#
var oblist = new List<object>() { "value 1", "Value 2", "Value 3"};
```

The update method is:

```C#
SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum valueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;

ValueRange requestBody = new ValueRange();

var oblist = new List<object>() { "YOUR SPREADSHEET VALUE" };
requestBody.Values = new List<IList<object>> { oblist };

SpreadsheetsResource.ValuesResource.UpdateRequest request = sheetsService.Spreadsheets.Values.Update(requestBody, spreadsheetId, range);
request.ValueInputOption = valueInputOption;

UpdateValuesResponse response = request.Execute();
```

## Delete method

The delete method is:

```C#
var requestBody = new ClearValuesRequest();

var deleteRequest = sheetsService.Spreadsheets.Values.Clear(requestBody, spreadsheetId, range);
var deleteReponse = deleteRequest.Execute();
```



