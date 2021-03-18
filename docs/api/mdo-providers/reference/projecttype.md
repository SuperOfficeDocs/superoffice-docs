---
uid: projecttype
title: projecttype
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

# "projecttype" MDO List
Project type list. Encodes Default project duration in extra info.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectTypeProvider">ProjectTypeProvider</see> class.
The name of the MDO list is 'projecttype'.




## Sample Request

```http!
GET /api/v1/MDOList/projecttype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("projecttype", forceFlatList: true);
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

* "projecttypeheadings"
* "projecttypeheadingswithallitem"
* "projecttypeheadingswithallitemwithnoselection"
* "projecttypeheadingswithnoselection"
* "projecttypewithallitem"
* "projecttypewithallitemwithnoselection"
* "projecttypewithnoselection"
