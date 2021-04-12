---
uid: preferencelineitem
title: preferencelineitem
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "preferencelineitem"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "preferencelineitem" MDO List
The name of the MDO list is 'preferencelineitem'.




## Sample Request

```http!
GET /api/v1/MDOList/preferencelineitem
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("preferencelineitem", forceFlatList: true);
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

* "preferencelineitemheadings"
* "preferencelineitemheadingswithallitem"
* "preferencelineitemheadingswithallitemwithnoselection"
* "preferencelineitemheadingswithnoselection"
* "preferencelineitemwithallitem"
* "preferencelineitemwithallitemwithnoselection"
* "preferencelineitemwithnoselection"
