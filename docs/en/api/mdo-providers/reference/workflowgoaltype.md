---
uid: workflowgoaltype
title: workflowgoaltype
keywords: mdoprovider mdo provider workflowgoaltype
description: MDO provider for the WorkflowGoalType enum
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("workflowgoaltype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_WORKFLOWGOALTYPE_CONTACTUPDATED]|||
|2|[SR_WORKFLOWGOALTYPE_SALECREATEDONCONTACT]|||
|3|[SR_WORKFLOWGOALTYPE_SALECREATEDONCOMPANY]|||
|4|[SR_WORKFLOWGOALTYPE_APPOINTMENTCREATED]|||
|5|[SR_WORKFLOWGOALTYPE_ADDEDTOPROJECT]|||
|6|[SR_WORKFLOWGOALTYPE_ADDEDTOSELECTION]|||
|7|[SR_WORKFLOWGOALTYPE_FORMSUBMITTED]|||
|8|[SR_WORKFLOWGOALTYPE_HADCHAT]|||
|9|[SR_WORKFLOWGOALTYPE_LINKCLICKED]|||
|10|[SR_WORKFLOWGOALTYPE_REQUESTCREATED]|||


## Related MDO Lists

* "workflowgoaltypeheadings"
* "workflowgoaltypeheadingswithallitem"
* "workflowgoaltypeheadingswithallitemwithnoselection"
* "workflowgoaltypeheadingswithnoselection"
* "workflowgoaltypewithallitem"
* "workflowgoaltypewithallitemwithnoselection"
* "workflowgoaltypewithnoselection"
