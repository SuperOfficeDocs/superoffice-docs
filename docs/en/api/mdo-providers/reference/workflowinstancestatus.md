---
uid: workflowinstancestatus
title: workflowinstancestatus
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "workflowinstancestatus"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "workflowinstancestatus" MDO List
MDO provider for the WorkflowInstanceStatus enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WorkflowInstanceStatusProvider">WorkflowInstanceStatusProvider</see> class.
The name of the MDO list is 'workflowinstancestatus'.




## Sample Request

```http!
GET /api/v1/MDOList/workflowinstancestatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("workflowinstancestatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Idle|||
|2|Running|||
|3|Finished|||
|4|Suspended|||
|5|Faulted|||
|6|Cancelled|||


## Related MDO Lists

* "workflowinstancestatusheadings"
* "workflowinstancestatusheadingswithallitem"
* "workflowinstancestatusheadingswithallitemwithnoselection"
* "workflowinstancestatusheadingswithnoselection"
* "workflowinstancestatuswithallitem"
* "workflowinstancestatuswithallitemwithnoselection"
* "workflowinstancestatuswithnoselection"
