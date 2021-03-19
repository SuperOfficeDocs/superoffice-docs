---
uid: quotedocumentorderbyfields
title: quotedocumentorderbyfields
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "quotedocumentorderbyfields"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "quotedocumentorderbyfields" MDO List
Possible choices for fields you can ORDER BY, within a group (or without grouping)

Candidate fields have to be in the QuoteLine table. The double-buffering system in the document
production provider means you can sort on any field at all.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteDocumentOrderByFields">QuoteDocumentOrderByFields</see> class.
The name of the MDO list is 'quotedocumentorderbyfields'.




## Sample Request

```http!
GET /api/v1/MDOList/quotedocumentorderbyfields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quotedocumentorderbyfields", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Rank||rank|
|2|Code||code|
|3|Name||name|
|4|Product category||productCategoryKey|
|5|Product family||productFamilyKey|
|6|Product type||productTypeKey|
|7|Subscription||isSubscription|
|8|VAT info||vatInfo|


## Related MDO Lists

* "quotedocumentorderbyfieldsheadings"
* "quotedocumentorderbyfieldsheadingswithallitem"
* "quotedocumentorderbyfieldsheadingswithallitemwithnoselection"
* "quotedocumentorderbyfieldsheadingswithnoselection"
* "quotedocumentorderbyfieldswithallitem"
* "quotedocumentorderbyfieldswithallitemwithnoselection"
* "quotedocumentorderbyfieldswithnoselection"
