---
uid: workflowtriggertype
title: workflowtriggertype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "workflowtriggertype"
so.generated: true
so.date: 05.09.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("workflowtriggertype", forceFlatList: true);
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
|3|Wait (time based)|||
|4|Wait for action|||
|5|Split|||
|6|Update contact|||
|7|Add to list|||
|8|Remove from list|||
|9|Create request|||
|10|Create follow-up|||
|11|Create sale|||
|12|Notify by email|||
|13|Notify by SMS|||


## Related MDO Lists

* "workflowtriggertypeheadings"
* "workflowtriggertypeheadingswithallitem"
* "workflowtriggertypeheadingswithallitemwithnoselection"
* "workflowtriggertypeheadingswithnoselection"
* "workflowtriggertypewithallitem"
* "workflowtriggertypewithallitemwithnoselection"
* "workflowtriggertypewithnoselection"
