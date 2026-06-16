---
uid: workflowsteptype
title: workflowsteptype
keywords: mdoprovider mdo provider workflowsteptype
description: MDO provider for the WorkflowStepType enum
generated: true
content_type: reference
envir: onsite, online
---

# "workflowsteptype" MDO List
MDO provider for the WorkflowStepType enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WorkflowStepTypeProvider">WorkflowStepTypeProvider</see> class.
The name of the MDO list is 'workflowsteptype'.




## Sample Request

```http!
GET /api/v1/MDOList/workflowsteptype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("workflowsteptype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_WORKFLOWSTEPTYPE_SEND_EMAIL]|||
|2|[SR_WORKFLOWSTEPTYPE_SEND_SMS]|||
|3|[SR_WORKFLOWSTEPTYPE_WAIT_FOR_TIME]|||
|4|[SR_WORKFLOWSTEPTYPE_WAIT_FOR_ACTION]|||
|5|[SR_WORKFLOWSTEPTYPE_SPLIT]|||
|6|[SR_WORKFLOWSTEPTYPE_UPDATE_CONTACT]|||
|7|[SR_WORKFLOWSTEPTYPE_ADD_TO_LIST]|||
|8|[SR_WORKFLOWSTEPTYPE_REMOVE_FROM_LIST]|||
|15|[SR_WORKFLOWSTEPTYPE_DISTRIBUTE_TO_OWNER]|||
|9|[SR_WORKFLOWSTEPTYPE_CREATE_REQUEST]|||
|10|[SR_WORKFLOWSTEPTYPE_CREATE_FOLLOWUP]|||
|11|[SR_WORKFLOWSTEPTYPE_CREATE_SALE]|||
|14|[SR_WORKFLOWSTEPTYPE_RUN_SCRIPT]|||
|12|[SR_WORKFLOWSTEPTYPE_NOTIFY_BY_EMAIL]|||
|13|[SR_WORKFLOWSTEPTYPE_NOTIFY_BY_SMS]|||


## Related MDO Lists

* "workflowsteptypeheadings"
* "workflowsteptypeheadingswithallitem"
* "workflowsteptypeheadingswithallitemwithnoselection"
* "workflowsteptypeheadingswithnoselection"
* "workflowsteptypewithallitem"
* "workflowsteptypewithallitemwithnoselection"
* "workflowsteptypewithnoselection"
