---
uid: quotedocuments
title: quotedocuments
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "quotedocuments" MDO List
The name of the MDO list is 'quotedocuments'.




## Sample Request

```http!
GET /api/v1/MDOList/quotedocuments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quotedocuments", forceFlatList: true);
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

* "quotedocumentsheadings"
* "quotedocumentsheadingswithallitem"
* "quotedocumentsheadingswithallitemwithnoselection"
* "quotedocumentsheadingswithnoselection"
* "quotedocumentswithallitem"
* "quotedocumentswithallitemwithnoselection"
* "quotedocumentswithnoselection"
