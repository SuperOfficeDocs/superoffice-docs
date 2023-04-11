---
uid: workflowgoaltype
title: workflowgoaltype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "workflowgoaltype"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "workflowgoaltype" MDO List
MDO provider for the WorkflowGoalType enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WorkflowGoalTypeProvider">WorkflowGoalTypeProvider</see> class.
The name of the MDO list is 'workflowgoaltype'.




## Sample Request

```http!
GET /api/v1/MDOList/workflowgoaltype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("workflowgoaltype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Contact updated|||
|2|Sale created on contact|||
|3|Sale created on company|||
|4|Appointment created|||
|5|Added to project|||
|6|Added to selection|||
|7|Form submitted|||
|8|Had chat|||
|9|Link clicked|||
|10|Request created|||


## Related MDO Lists

* "workflowgoaltypeheadings"
* "workflowgoaltypeheadingswithallitem"
* "workflowgoaltypeheadingswithallitemwithnoselection"
* "workflowgoaltypeheadingswithnoselection"
* "workflowgoaltypewithallitem"
* "workflowgoaltypewithallitemwithnoselection"
* "workflowgoaltypewithnoselection"
