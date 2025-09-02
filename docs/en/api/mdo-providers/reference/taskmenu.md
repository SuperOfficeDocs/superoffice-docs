---
uid: taskmenu
title: taskmenu
keywords: mdoprovider mdo provider taskmenu
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "taskmenu" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'taskmenu'.




## Sample Request

```http!
GET /api/v1/MDOList/taskmenu
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("taskmenu", forceFlatList: true);
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

* "taskmenuheadings"
* "taskmenuheadingswithallitem"
* "taskmenuheadingswithallitemwithnoselection"
* "taskmenuheadingswithnoselection"
* "taskmenuwithallitem"
* "taskmenuwithallitemwithnoselection"
* "taskmenuwithnoselection"
