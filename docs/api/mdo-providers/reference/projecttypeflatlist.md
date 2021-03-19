---
uid: projecttypeflatlist
title: projecttypeflatlist
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "projecttypeflatlist"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "projecttypeflatlist" MDO List
Project type list. Encodes Default project duration in extra info.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectTypeFlatListProvider">ProjectTypeFlatListProvider</see> class.
The name of the MDO list is 'projecttypeflatlist'.




## Sample Request

```http!
GET /api/v1/MDOList/projecttypeflatlist
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("projecttypeflatlist", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Annet||duration=0&unit=0|
|1|DM/Kampanje||duration=0&unit=0|
|4|Guided project||duration=3&unit=6|
|2|Internt||duration=0&unit=0|


## Related MDO Lists

* "projecttypeflatlistheadings"
* "projecttypeflatlistheadingswithallitem"
* "projecttypeflatlistheadingswithallitemwithnoselection"
* "projecttypeflatlistheadingswithnoselection"
* "projecttypeflatlistwithallitem"
* "projecttypeflatlistwithallitemwithnoselection"
* "projecttypeflatlistwithnoselection"
