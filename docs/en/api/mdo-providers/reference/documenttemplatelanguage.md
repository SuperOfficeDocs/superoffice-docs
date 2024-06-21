---
uid: documenttemplatelanguage
title: documenttemplatelanguage
keywords: mdoprovider mdo provider documenttemplatelanguage
description: 
generated: true
topic: reference
envir: onsite, online
---

# "documenttemplatelanguage" MDO List
The name of the MDO list is 'documenttemplatelanguage'.




## Sample Request

```http!
GET /api/v1/MDOList/documenttemplatelanguage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("documenttemplatelanguage", forceFlatList: true);
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

* "documenttemplatelanguageheadings"
* "documenttemplatelanguageheadingswithallitem"
* "documenttemplatelanguageheadingswithallitemwithnoselection"
* "documenttemplatelanguageheadingswithnoselection"
* "documenttemplatelanguagewithallitem"
* "documenttemplatelanguagewithallitemwithnoselection"
* "documenttemplatelanguagewithnoselection"
