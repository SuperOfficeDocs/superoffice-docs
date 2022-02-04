---
uid: quotelinestatus
title: quotelinestatus
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "quotelinestatus"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "quotelinestatus" MDO List
Hard-coded list of values for the QuoteLine.Status field, see <see cref="T:SuperOffice.Data.QuoteStatus" /> enum.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteLineStatus">QuoteLineStatus</see> class.
The name of the MDO list is 'quotelinestatus'.




## Sample Request

```http!
GET /api/v1/MDOList/quotelinestatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quotelinestatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|OK|||
|1|OK with information|||
|2|Warning|||
|3|Error|||


## Related MDO Lists

* "quotelinestatusheadings"
* "quotelinestatusheadingswithallitem"
* "quotelinestatusheadingswithallitemwithnoselection"
* "quotelinestatusheadingswithnoselection"
* "quotelinestatuswithallitem"
* "quotelinestatuswithallitemwithnoselection"
* "quotelinestatuswithnoselection"
