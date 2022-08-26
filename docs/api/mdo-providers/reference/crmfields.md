---
uid: crmfields
title: crmfields
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "crmfields"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "crmfields" MDO List
The name of the MDO list is 'crmfields'.




## Sample Request

```http!
GET /api/v1/MDOList/crmfields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("crmfields", forceFlatList: true);
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

* "crmfieldsheadings"
* "crmfieldsheadingswithallitem"
* "crmfieldsheadingswithallitemwithnoselection"
* "crmfieldsheadingswithnoselection"
* "crmfieldswithallitem"
* "crmfieldswithallitemwithnoselection"
* "crmfieldswithnoselection"
