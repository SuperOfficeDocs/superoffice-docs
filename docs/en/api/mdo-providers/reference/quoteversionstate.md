---
uid: quoteversionstate
title: quoteversionstate
keywords: mdoprovider mdo provider quoteversionstate
description: List provider for the <see cref="T:SuperOffice.Data.QuoteVersionState" /> enum
generated: true
content_type: reference
envir: onsite, online
---

# "quoteversionstate" MDO List
List provider for the <see cref="T:SuperOffice.Data.QuoteVersionState" /> enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteVersionStateListProvider">QuoteVersionStateListProvider</see> class.
The name of the MDO list is 'quoteversionstate'.




## Sample Request

```http!
GET /api/v1/MDOList/quoteversionstate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("quoteversionstate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Draft|||
|2|Draft - not calculated|||
|3|Needs Approval|||
|4|Approved|||
|5|Not Approved|||
|6|Sent|||
|7|Archived|||
|8|Lost|||
|9|Sold|||


## Related MDO Lists

* "quoteversionstateheadings"
* "quoteversionstateheadingswithallitem"
* "quoteversionstateheadingswithallitemwithnoselection"
* "quoteversionstateheadingswithnoselection"
* "quoteversionstatewithallitem"
* "quoteversionstatewithallitemwithnoselection"
* "quoteversionstatewithnoselection"
