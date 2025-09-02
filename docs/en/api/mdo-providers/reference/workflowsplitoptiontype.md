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
|1|Contact data|||
|2|Form submission yes/no|||
|6|Form data|||
|3|Link clicked|||
|4|Project membership|||
|5|Selection membership|||


## Related MDO Lists

* "workflowsplitoptiontypeheadings"
* "workflowsplitoptiontypeheadingswithallitem"
* "workflowsplitoptiontypeheadingswithallitemwithnoselection"
* "workflowsplitoptiontypeheadingswithnoselection"
* "workflowsplitoptiontypewithallitem"
* "workflowsplitoptiontypewithallitemwithnoselection"
* "workflowsplitoptiontypewithnoselection"
