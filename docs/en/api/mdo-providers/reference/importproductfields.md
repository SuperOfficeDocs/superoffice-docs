---
uid: importproductfields
title: importproductfields
keywords: mdoprovider mdo provider importproductfields
description: MDO provider for column headers used in import
generated: true
content_type: reference
envir: onsite, online
---

# "importproductfields" MDO List
MDO provider for column headers used in import



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportProductFieldsProvider">ImportProductFieldsProvider</see> class.
The name of the MDO list is 'importproductfields'.




## Sample Request

```http!
GET /api/v1/MDOList/importproductfields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importproductfields", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_NAME]|||
|1|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_DESCRIPTION]|||
|2|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_CODE]|||
|3|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_UNIT]|||
|4|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_ISSUBSCRIPTION]|||
|5|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_SUBSCRIPTIONUNIT]|||
|6|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_SUBSCRIPTIONQUANTITY]|||
|7|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_ITEMNUMBER]|||
|8|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_URL]|||
|9|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_PRODUCTCATEGORYKEY]|||
|10|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_PRODUCTFAMILYKEY]|||
|11|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_PRODUCTTYPEKEY]|||
|12|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_VATINFO]|||
|13|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_VAT]|||
|14|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_UNITCOST]|||
|15|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_UNITMINIMUMPRICE]|||
|16|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_UNITLISTPRICE]|||
|17|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_EXTRAINFO]|||
|18|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_INASSORTMENT]|||
|19|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_SUPPLIER]|||
|20|[SR_SINGULAR_PRODUCT]: [SR_QUOTE_QUOTELINE_SUPPLIERCODE]|||


## Related MDO Lists

* "importproductfieldsheadings"
* "importproductfieldsheadingswithallitem"
* "importproductfieldsheadingswithallitemwithnoselection"
* "importproductfieldsheadingswithnoselection"
* "importproductfieldswithallitem"
* "importproductfieldswithallitemwithnoselection"
* "importproductfieldswithnoselection"
