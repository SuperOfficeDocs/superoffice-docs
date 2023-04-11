---
uid: targetentitytype
title: targetentitytype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "targetentitytype"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "targetentitytype" MDO List
TargetEntities



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TargetEntityTypeProvider">TargetEntityTypeProvider</see> class.
The name of the MDO list is 'targetentitytype'.




## Sample Request

```http!
GET /api/v1/MDOList/targetentitytype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("targetentitytype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Sale|||


## Related MDO Lists

* "targetentitytypeheadings"
* "targetentitytypeheadingswithallitem"
* "targetentitytypeheadingswithallitemwithnoselection"
* "targetentitytypeheadingswithnoselection"
* "targetentitytypewithallitem"
* "targetentitytypewithallitemwithnoselection"
* "targetentitytypewithnoselection"
