---
uid: quotelinestatus
title: quotelinestatus
keywords: mdoprovider mdo provider quotelinestatus
description: Hard-coded list of values for the QuoteLine.Status field, see <see cref="T:SuperOffice.Data.QuoteStatus" /> enum.
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("quotelinestatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_QUOTE_QUOTELINE_RESPONSE_OK]|||
|1|[SR_QUOTE_QUOTELINE_RESPONSE_OKWITHINFO]|||
|2|[SR_QUOTE_QUOTELINE_RESPONSE_WARNING]|||
|3|[SR_QUOTE_QUOTELINE_RESPONSE_ERROR]|||


## Related MDO Lists

* "quotelinestatusheadings"
* "quotelinestatusheadingswithallitem"
* "quotelinestatusheadingswithallitemwithnoselection"
* "quotelinestatusheadingswithnoselection"
* "quotelinestatuswithallitem"
* "quotelinestatuswithallitemwithnoselection"
* "quotelinestatuswithnoselection"
