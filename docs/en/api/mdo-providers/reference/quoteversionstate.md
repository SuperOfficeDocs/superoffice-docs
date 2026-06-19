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
|1|[SR_QUOTE_QUOTEVERSION_DRAFT]|||
|2|[SR_QUOTE_QUOTEVERSION_DRAFT_NOTCALCULATED]|||
|3|[SR_QUOTE_QUOTEVERSION_NEEDSAPPROVAL]|||
|4|[SR_QUOTE_QUOTEVERSION_APPROVED]|||
|5|[SR_QUOTE_QUOTEVERSION_DISAPPROVED]|||
|6|[SR_QUOTE_QUOTEVERSION_SENT]|||
|7|[SR_QUOTE_QUOTEVERSION_ARCHIVED]|||
|8|[SR_QUOTE_QUOTEVERSION_REJECTED]|||
|9|[SR_QUOTE_QUOTEVERSION_SOLD]|||


## Related MDO Lists

* "quoteversionstateheadings"
* "quoteversionstateheadingswithallitem"
* "quoteversionstateheadingswithallitemwithnoselection"
* "quoteversionstateheadingswithnoselection"
* "quoteversionstatewithallitem"
* "quoteversionstatewithallitemwithnoselection"
* "quoteversionstatewithnoselection"
