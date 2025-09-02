---
uid: projecttypeflatlist
title: projecttypeflatlist
keywords: mdoprovider mdo provider projecttypeflatlist
description: Project type list. Encodes Default project duration in extra info.
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("projecttypeflatlist", forceFlatList: true);
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
