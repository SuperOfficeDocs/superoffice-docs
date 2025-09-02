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
|1|Send e-mail|||
|2|Send SMS|||
|3|Wait time|||
|4|Wait for action|||
|5|Split|||
|6|Update contact|||
|7|Add to selection/project|||
|8|Remove from selection/project|||
|15|Distribute to owner|||
|9|Create request|||
|10|Create follow-up|||
|11|Create sale|||
|14|Run script|||
|12|Notify by e-mail|||
|13|Notify by SMS|||


## Related MDO Lists

* "workflowsteptypeheadings"
* "workflowsteptypeheadingswithallitem"
* "workflowsteptypeheadingswithallitemwithnoselection"
* "workflowsteptypeheadingswithnoselection"
* "workflowsteptypewithallitem"
* "workflowsteptypewithallitemwithnoselection"
* "workflowsteptypewithnoselection"
