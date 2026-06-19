---
uid: workflowsplitoptiontype
title: workflowsplitoptiontype
keywords: mdoprovider mdo provider workflowsplitoptiontype
description: MDO provider for the WorkflowTriggerType enum
generated: true
content_type: reference
envir: onsite, online
---

# "workflowsplitoptiontype" MDO List
MDO provider for the WorkflowTriggerType enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WorkflowSplitOptionTypeProvider">WorkflowSplitOptionTypeProvider</see> class.
The name of the MDO list is 'workflowsplitoptiontype'.




## Sample Request

```http!
GET /api/v1/MDOList/workflowsplitoptiontype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("workflowsplitoptiontype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_FLOW_SPLIT_PERSONDATA]|||
|2|[SR_FLOW_SPLIT_FORMSUBMISSION]|||
|6|[SR_FLOW_SPLIT_FORMDATA]|||
|3|[SR_FLOW_SPLIT_LINKCLICKED]|||
|4|[SR_FLOW_SPLIT_PROJECTMEMBERSHIP]|||
|5|[SR_FLOW_SPLIT_SELECTIONMEMBERSHIP]|||


## Related MDO Lists

* "workflowsplitoptiontypeheadings"
* "workflowsplitoptiontypeheadingswithallitem"
* "workflowsplitoptiontypeheadingswithallitemwithnoselection"
* "workflowsplitoptiontypeheadingswithnoselection"
* "workflowsplitoptiontypewithallitem"
* "workflowsplitoptiontypewithallitemwithnoselection"
* "workflowsplitoptiontypewithnoselection"
