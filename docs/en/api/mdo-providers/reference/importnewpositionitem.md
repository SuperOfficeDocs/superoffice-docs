---
uid: importnewpositionitem
title: importnewpositionitem
keywords: mdoprovider mdo provider importnewpositionitem
description: Import position items - Add to list, set to blank
generated: true
content_type: reference
envir: onsite, online
---

# "importnewpositionitem" MDO List
Import position items: Add to list, set to blank



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportNewPositionItemProvider">ImportNewPositionItemProvider</see> class.
The name of the MDO list is 'importnewpositionitem'.




## Sample Request

```http!
GET /api/v1/MDOList/importnewpositionitem
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importnewpositionitem", forceFlatList: true);
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

* "importnewpositionitemheadings"
* "importnewpositionitemheadingswithallitem"
* "importnewpositionitemheadingswithallitemwithnoselection"
* "importnewpositionitemheadingswithnoselection"
* "importnewpositionitemwithallitem"
* "importnewpositionitemwithallitemwithnoselection"
* "importnewpositionitemwithnoselection"
