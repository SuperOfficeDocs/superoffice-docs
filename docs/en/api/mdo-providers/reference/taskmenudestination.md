---
uid: taskmenudestination
title: taskmenudestination
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "taskmenudestination"
so.generated: true
so.date: 05.09.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "taskmenudestination" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TaskMenuDestinationProvider">TaskMenuDestinationProvider</see> class.
The name of the MDO list is 'taskmenudestination'.




## Sample Request

```http!
GET /api/v1/MDOList/taskmenudestination
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("taskmenudestination", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Company||contact|
|2|Contact||person|
|3|Sale||sale|
|4|Project||project|
|5|Appointment||appointment|
|6|Document||document|
|7|Quote||Quote|
|8|Request||ticket|
|9|Request - Message||ej_message|


## Related MDO Lists

* "taskmenudestinationheadings"
* "taskmenudestinationheadingswithallitem"
* "taskmenudestinationheadingswithallitemwithnoselection"
* "taskmenudestinationheadingswithnoselection"
* "taskmenudestinationwithallitem"
* "taskmenudestinationwithallitemwithnoselection"
* "taskmenudestinationwithnoselection"
