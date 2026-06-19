---
uid: quotedocumentorderbyfields
title: quotedocumentorderbyfields
keywords: mdoprovider mdo provider quotedocumentorderbyfields
description: Possible choices for fields you can ORDER BY, within a group (or without grouping)
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("quotedocumentorderbyfields", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_QUOTE_QUOTELINE_RANK]||rank|
|2|[SR_QUOTE_QUOTELINE_CODE]||code|
|3|[SR_QUOTE_QUOTELINE_NAME]||name|
|4|[SR_QUOTE_QUOTELINE_PRODUCTCATEGORYKEY]||productCategoryKey|
|5|[SR_QUOTE_QUOTELINE_PRODUCTFAMILYKEY]||productFamilyKey|
|6|[SR_QUOTE_QUOTELINE_PRODUCTTYPEKEY]||productTypeKey|
|7|[SR_QUOTE_QUOTELINE_ISSUBSCRIPTION]||isSubscription|
|8|[SR_QUOTE_QUOTELINE_VATINFO]||vatInfo|


## Related MDO Lists

* "quotedocumentorderbyfieldsheadings"
* "quotedocumentorderbyfieldsheadingswithallitem"
* "quotedocumentorderbyfieldsheadingswithallitemwithnoselection"
* "quotedocumentorderbyfieldsheadingswithnoselection"
* "quotedocumentorderbyfieldswithallitem"
* "quotedocumentorderbyfieldswithallitemwithnoselection"
* "quotedocumentorderbyfieldswithnoselection"
