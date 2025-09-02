---
uid: erpproductcategory
title: erpproductcategory
keywords: mdoprovider mdo provider erpproductcategory
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "erpproductcategory" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteListsByIdProvider">QuoteListsByIdProvider</see> class.
The name of the MDO list is 'erpproductcategory'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Quote alternative implies sale id, which tells us which quote connection to get| QuoteAlternativeId|1234|
|Sale to get quotes from which tells us which quote connection to get| SaleId|1234|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/erpproductcategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("erpproductcategory", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "erpproductcategoryheadings"
* "erpproductcategoryheadingswithallitem"
* "erpproductcategoryheadingswithallitemwithnoselection"
* "erpproductcategoryheadingswithnoselection"
* "erpproductcategorywithallitem"
* "erpproductcategorywithallitemwithnoselection"
* "erpproductcategorywithnoselection"
