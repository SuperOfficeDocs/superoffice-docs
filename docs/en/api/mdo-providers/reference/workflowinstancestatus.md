---
uid: workflowinstancestatus
title: workflowinstancestatus
keywords: mdoprovider mdo provider workflowinstancestatus
description: MDO provider for the WorkflowInstanceStatus enum
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("workflowinstancestatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|[SR_WORKFLOW_INSTANCE_STATUS_ACTIVE]|||
|3|[SR_WORKFLOW_INSTANCE_STATUS_FINISHED]|||
|4|[SR_WORKFLOW_INSTANCE_STATUS_FINISHEDWITHSUCCESS]|||
|5|[SR_WORKFLOW_INSTANCE_STATUS_DROPOUT]|||
|6|[SR_WORKFLOW_INSTANCE_STATUS_CANCELLED]|||


## Related MDO Lists

* "workflowinstancestatusheadings"
* "workflowinstancestatusheadingswithallitem"
* "workflowinstancestatusheadingswithallitemwithnoselection"
* "workflowinstancestatusheadingswithnoselection"
* "workflowinstancestatuswithallitem"
* "workflowinstancestatuswithallitemwithnoselection"
* "workflowinstancestatuswithnoselection"
