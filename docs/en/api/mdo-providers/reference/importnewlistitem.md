---
uid: importnewlistitem
title: importnewlistitem
keywords: mdoprovider mdo provider importnewlistitem
description: Import list items - Add item, use default, use blank
generated: true
content_type: reference
envir: onsite, online
---

# "importnewlistitem" MDO List
Import list items: Add item, use default, use blank



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportNewListItemProvider">ImportNewListItemProvider</see> class.
The name of the MDO list is 'importnewlistitem'.




## Sample Request

```http!
GET /api/v1/MDOList/importnewlistitem
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importnewlistitem", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Add new item to list|||
|2|Ignore - use default|||
|3|Ignore - set to blank|||


## Related MDO Lists

* "importnewlistitemheadings"
* "importnewlistitemheadingswithallitem"
* "importnewlistitemheadingswithallitemwithnoselection"
* "importnewlistitemheadingswithnoselection"
* "importnewlistitemwithallitem"
* "importnewlistitemwithallitemwithnoselection"
* "importnewlistitemwithnoselection"
