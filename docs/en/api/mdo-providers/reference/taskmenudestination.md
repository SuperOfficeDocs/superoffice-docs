---
uid: taskmenudestination
title: taskmenudestination
keywords: mdoprovider mdo provider taskmenudestination
description: 
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("taskmenudestination", forceFlatList: true);
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
|5|Follow-up||appointment|
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
