---
uid: workflowtimewaitintervaltype
title: workflowtimewaitintervaltype
keywords: mdoprovider mdo provider workflowtimewaitintervaltype
description: MDO provider for the WorkflowTimeWaitIntervalType enum
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("workflowtimewaitintervaltype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|[SR_WORKFLOWSTEP_WAIT_LISTITEM_MINUNTES]|||
|3|[SR_WORKFLOWSTEP_WAIT_LISTITEM_HOURS]|||
|5|[SR_WORKFLOWSTEP_WAIT_LISTITEM_DAYS]|||
|4|[SR_WORKFLOWSTEP_WAIT_LISTITEM_WORKINGDAYS]|||
|6|[SR_WORKFLOWSTEP_WAIT_LISTITEM_WEEKS]|||


## Related MDO Lists

* "workflowtimewaitintervaltypeheadings"
* "workflowtimewaitintervaltypeheadingswithallitem"
* "workflowtimewaitintervaltypeheadingswithallitemwithnoselection"
* "workflowtimewaitintervaltypeheadingswithnoselection"
* "workflowtimewaitintervaltypewithallitem"
* "workflowtimewaitintervaltypewithallitemwithnoselection"
* "workflowtimewaitintervaltypewithnoselection"
