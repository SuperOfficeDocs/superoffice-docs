---
uid: workflowsteptype
title: workflowsteptype
keywords: mdoprovider mdo provider workflowsteptype
description: MDO provider for the WorkflowStepType enum
so.generated: true
so.topic: reference
so.envir: onsite, online
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("workflowsteptype", forceFlatList: true);
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
|7|Add to selection and/or project|||
|8|Remove from selection and/or project|||
|9|Create request|||
|10|Create follow-up|||
|11|Create sale|||
|12|Notify by e-mail|||
|13|Notify by SMS|||
|14|Run script|||


## Related MDO Lists

* "workflowsteptypeheadings"
* "workflowsteptypeheadingswithallitem"
* "workflowsteptypeheadingswithallitemwithnoselection"
* "workflowsteptypeheadingswithnoselection"
* "workflowsteptypewithallitem"
* "workflowsteptypewithallitemwithnoselection"
* "workflowsteptypewithnoselection"
