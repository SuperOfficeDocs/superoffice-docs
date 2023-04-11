---
uid: workflowdefinitionstatus
title: workflowdefinitionstatus
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "workflowdefinitionstatus"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "workflowdefinitionstatus" MDO List
MDO provider for the WorkflowDefinitionStatus enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WorkflowDefinitionStatusProvider">WorkflowDefinitionStatusProvider</see> class.
The name of the MDO list is 'workflowdefinitionstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/workflowdefinitionstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("workflowdefinitionstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Stopped|||
|2|Paused|||
|3|Running|||


## Related MDO Lists

* "workflowdefinitionstatusheadings"
* "workflowdefinitionstatusheadingswithallitem"
* "workflowdefinitionstatusheadingswithallitemwithnoselection"
* "workflowdefinitionstatusheadingswithnoselection"
* "workflowdefinitionstatuswithallitem"
* "workflowdefinitionstatuswithallitemwithnoselection"
* "workflowdefinitionstatuswithnoselection"
