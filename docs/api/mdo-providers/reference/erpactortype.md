---
uid: erpactortype
title: erpactortype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "erpactortype"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "erpactortype" MDO List

Implemented by the <see cref="T:SuperOffice.CRM.Lists.ErpActorTypeProvider">ErpActorTypeProvider</see> class.
The name of the MDO list is 'erpactortype'.

## Sample Request

```http!
GET /api/v1/MDOList/erpactortype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("erpactortype", forceFlatList: true);
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

* "erpactortypeheadings"
* "erpactortypeheadingswithallitem"
* "erpactortypeheadingswithallitemwithnoselection"
* "erpactortypeheadingswithnoselection"
* "erpactortypewithallitem"
* "erpactortypewithallitemwithnoselection"
* "erpactortypewithnoselection"
