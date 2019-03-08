# Read Data

Necessary params:

```C#
String spreadsheetId = "YOUR SPREADSHEET ID";
String range = "YOUR SPREADSHEET RANGE";
```

## Read method

The read method is:

```C#
SpreadsheetsResource.ValuesResource.GetRequest request = 
        service.Spreadsheets.Values.Get(spreadsheetId, range);
ValueRange response = request.Execute();
```

and ValueRange is:

```C#
public class ValueRange : IDirectResponseSchema
{
    public ValueRange();

    public virtual string MajorDimension { get; set; }
    public virtual string Range { get; set; }
    public virtual IList<IList<object>> Values { get; set; }
    public virtual string ETag { get; set; }
}
```

