---
uid: importnewproductlistitem
title: importnewproductlistitem
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "importnewproductlistitem"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("importnewproductlistitem", forceFlatList: true);
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
