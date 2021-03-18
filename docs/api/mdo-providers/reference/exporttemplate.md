---
uid: exporttemplate
title: exporttemplate
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

# "exporttemplate" MDO List
The name of the MDO list is 'exporttemplate'.




## Sample Request

```http!
GET /api/v1/MDOList/exporttemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("exporttemplate", forceFlatList: true);
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

* "exporttemplateheadings"
* "exporttemplateheadingswithallitem"
* "exporttemplateheadingswithallitemwithnoselection"
* "exporttemplateheadingswithnoselection"
* "exporttemplatewithallitem"
* "exporttemplatewithallitemwithnoselection"
* "exporttemplatewithnoselection"
