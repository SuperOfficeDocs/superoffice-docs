---
uid: workflowtimewaitintervaltype
title: workflowtimewaitintervaltype
keywords: mdoprovider mdo provider workflowtimewaitintervaltype
description: MDO provider for the WorkflowTimeWaitIntervalType enum
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "workflowtimewaitintervaltype" MDO List
MDO provider for the WorkflowTimeWaitIntervalType enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WorkflowTimeWaitIntervalTypeProvider">WorkflowTimeWaitIntervalTypeProvider</see> class.
The name of the MDO list is 'workflowtimewaitintervaltype'.




## Sample Request

```http!
GET /api/v1/MDOList/workflowtimewaitintervaltype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("workflowtimewaitintervaltype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Minute(s)|||
|3|Hour(s)|||
|5|Day(s)|||
|4|Working day(s)|||
|6|Week(s)|||


## Related MDO Lists

* "workflowtimewaitintervaltypeheadings"
* "workflowtimewaitintervaltypeheadingswithallitem"
* "workflowtimewaitintervaltypeheadingswithallitemwithnoselection"
* "workflowtimewaitintervaltypeheadingswithnoselection"
* "workflowtimewaitintervaltypewithallitem"
* "workflowtimewaitintervaltypewithallitemwithnoselection"
* "workflowtimewaitintervaltypewithnoselection"
