---
uid: workflowtimewaitalgorithm
title: workflowtimewaitalgorithm
keywords: mdoprovider mdo provider workflowtimewaitalgorithm
description: MDO provider for the WorkflowTimeWaitAlgorithm enum
generated: true
content_type: reference
envir: onsite, online
---

# "workflowtimewaitalgorithm" MDO List
MDO provider for the WorkflowTimeWaitAlgorithm enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WorkflowTimeWaitAlgorithmProvider">WorkflowTimeWaitAlgorithmProvider</see> class.
The name of the MDO list is 'workflowtimewaitalgorithm'.




## Sample Request

```http!
GET /api/v1/MDOList/workflowtimewaitalgorithm
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("workflowtimewaitalgorithm", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Number of days/hours after previous step|||
|2|Until specific date/time|||


## Related MDO Lists

* "workflowtimewaitalgorithmheadings"
* "workflowtimewaitalgorithmheadingswithallitem"
* "workflowtimewaitalgorithmheadingswithallitemwithnoselection"
* "workflowtimewaitalgorithmheadingswithnoselection"
* "workflowtimewaitalgorithmwithallitem"
* "workflowtimewaitalgorithmwithallitemwithnoselection"
* "workflowtimewaitalgorithmwithnoselection"
