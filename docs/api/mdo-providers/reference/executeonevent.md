---
uid: executeonevent
title: executeonevent
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "executeonevent"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "executeonevent" MDO List
List of windows client events to execute tasks on: Logon, Logoff, LocalUpdate



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExecuteOnEventProvider">ExecuteOnEventProvider</see> class.
The name of the MDO list is 'executeonevent'.




## Sample Request

```http!
GET /api/v1/MDOList/executeonevent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("executeonevent", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SuperOffice CRM starts|||
|2|SuperOffice CRM exits|||
|3|Local Update|||


## Related MDO Lists

* "executeoneventheadings"
* "executeoneventheadingswithallitem"
* "executeoneventheadingswithallitemwithnoselection"
* "executeoneventheadingswithnoselection"
* "executeoneventwithallitem"
* "executeoneventwithallitemwithnoselection"
* "executeoneventwithnoselection"
