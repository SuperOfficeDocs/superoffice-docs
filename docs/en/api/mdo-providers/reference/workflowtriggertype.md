---
uid: workflowtriggertype
title: workflowtriggertype
keywords: mdoprovider mdo provider workflowtriggertype
description: MDO provider for the WorkflowTriggerType enum
generated: true
content_type: reference
envir: onsite, online
---

# "workflowtriggertype" MDO List
MDO provider for the WorkflowTriggerType enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WorkflowTriggerTypeProvider">WorkflowTriggerTypeProvider</see> class.
The name of the MDO list is 'workflowtriggertype'.




## Sample Request

```http!
GET /api/v1/MDOList/workflowtriggertype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("workflowtriggertype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|8|RC.SR_WORKFLOWTRIGGERTYPE_ADDEDMESSAGE|||
|3|RC.SR_WORKFLOWTRIGGERTYPE_ADDEDTOPROJECT|||
|6|RC.SR_WORKFLOWTRIGGERTYPE_ADDEDTOSELECTION|||
|1|RC.SR_WORKFLOWTRIGGERTYPE_CONTACTCREATED|||
|2|RC.SR_WORKFLOWTRIGGERTYPE_CONTACTUPDATED|||
|4|RC.SR_WORKFLOWTRIGGERTYPE_CREATEDREQUEST|||
|7|RC.SR_WORKFLOWTRIGGERTYPE_FORMSUBMITTED|||
|5|RC.SR_WORKFLOWTRIGGERTYPE_LINKCLICKED|||
|10|RC.SR_WORKFLOWTRIGGERTYPE_ORDERPLACED|||
|11|RC.SR_WORKFLOWTRIGGERTYPE_SALECREATED|||
|13|RC.SR_WORKFLOWTRIGGERTYPE_SALELOST|||
|12|RC.SR_WORKFLOWTRIGGERTYPE_SALESOLD|||
|9|RC.SR_WORKFLOWTRIGGERTYPE_STARTEDCHAT|||


## Related MDO Lists

* "workflowtriggertypeheadings"
* "workflowtriggertypeheadingswithallitem"
* "workflowtriggertypeheadingswithallitemwithnoselection"
* "workflowtriggertypeheadingswithnoselection"
* "workflowtriggertypewithallitem"
* "workflowtriggertypewithallitemwithnoselection"
* "workflowtriggertypewithnoselection"
