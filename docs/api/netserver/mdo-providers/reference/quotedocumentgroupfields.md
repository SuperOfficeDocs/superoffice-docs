---
uid: quotedocumentgroupfields
title: quotedocumentgroupfields
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "quotedocumentgroupfields"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "quotedocumentgroupfields" MDO List
Possible choices for fields that you can GROUP BY in quote detail documents.

Candidate fields have to be on the QuoteLine table, and not be numeric (can't group by price, for instance...)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteDocumentGroupFields">QuoteDocumentGroupFields</see> class.
The name of the MDO list is 'quotedocumentgroupfields'.




## Sample Request

```http!
GET /api/v1/MDOList/quotedocumentgroupfields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quotedocumentgroupfields", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Product category||productCategoryKey|
|2|Product family||productFamilyKey|
|3|Product type||productTypeKey|
|4|Subscription||isSubscription|
|5|VAT info||vatInfo|


## Related MDO Lists

* "quotedocumentgroupfieldsheadings"
* "quotedocumentgroupfieldsheadingswithallitem"
* "quotedocumentgroupfieldsheadingswithallitemwithnoselection"
* "quotedocumentgroupfieldsheadingswithnoselection"
* "quotedocumentgroupfieldswithallitem"
* "quotedocumentgroupfieldswithallitemwithnoselection"
* "quotedocumentgroupfieldswithnoselection"
