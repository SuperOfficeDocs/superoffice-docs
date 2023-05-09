---
uid: taskmenugroup
title: taskmenugroup
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "taskmenugroup"
so.generated: true
so.date: 05.09.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "taskmenugroup" MDO List
List of TaskMenus with visible for groups as commaseperated ids in extrainfo field.
This list only makes sence if the setting use groups and heading are turned on for



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TaskMenuGroupProvider">TaskMenuGroupProvider</see> class.
The name of the MDO list is 'taskmenugroup'.




## Sample Request

```http!
GET /api/v1/MDOList/taskmenugroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("taskmenugroup", forceFlatList: true);
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

* "taskmenugroupheadings"
* "taskmenugroupheadingswithallitem"
* "taskmenugroupheadingswithallitemwithnoselection"
* "taskmenugroupheadingswithnoselection"
* "taskmenugroupwithallitem"
* "taskmenugroupwithallitemwithnoselection"
* "taskmenugroupwithnoselection"
