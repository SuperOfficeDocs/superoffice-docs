---
uid: activitystatus
title: activitystatus
keywords: mdoprovider mdo provider activitystatus
description: MDO provider for the ActivityStatus enum - NotStarted, Started, Completed
generated: true
content_type: reference
envir: onsite, online
---

# "activitystatus" MDO List
MDO provider for the ActivityStatus enum: NotStarted, Started, Completed



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ActivityStatusProvider">ActivityStatusProvider</see> class.
The name of the MDO list is 'activitystatus'.




## Sample Request

```http!
GET /api/v1/MDOList/activitystatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("activitystatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Not started|||
|2|Not done|||
|3|Completed|||


## Related MDO Lists

* "activitystatusheadings"
* "activitystatusheadingswithallitem"
* "activitystatusheadingswithallitemwithnoselection"
* "activitystatusheadingswithnoselection"
* "activitystatuswithallitem"
* "activitystatuswithallitemwithnoselection"
* "activitystatuswithnoselection"
