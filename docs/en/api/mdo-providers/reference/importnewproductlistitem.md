---
uid: importnewproductlistitem
title: importnewproductlistitem
keywords: mdoprovider mdo provider importnewproductlistitem
description: Import product list items - add, use blank
generated: true
content_type: reference
envir: onsite, online
---

# "importnewproductlistitem" MDO List
Import product list items: add, use blank



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportNewProductListItemProvider">ImportNewProductListItemProvider</see> class.
The name of the MDO list is 'importnewproductlistitem'.




## Sample Request

```http!
GET /api/v1/MDOList/importnewproductlistitem
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importnewproductlistitem", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Add new item to list|||
|3|Ignore - set to blank|||


## Related MDO Lists

* "importnewproductlistitemheadings"
* "importnewproductlistitemheadingswithallitem"
* "importnewproductlistitemheadingswithallitemwithnoselection"
* "importnewproductlistitemheadingswithnoselection"
* "importnewproductlistitemwithallitem"
* "importnewproductlistitemwithallitemwithnoselection"
* "importnewproductlistitemwithnoselection"
