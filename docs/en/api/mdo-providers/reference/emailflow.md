---
uid: emailflow
title: emailflow
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "emailflow"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "emailflow" MDO List
List provider for EmailFlow



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EmailFlowListProvider">EmailFlowListProvider</see> class.
The name of the MDO list is 'emailflow'.




## Sample Request

```http!
GET /api/v1/MDOList/emailflow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("emailflow", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "emailflowheadings"
* "emailflowheadingswithallitem"
* "emailflowheadingswithallitemwithnoselection"
* "emailflowheadingswithnoselection"
* "emailflowwithallitem"
* "emailflowwithallitemwithnoselection"
* "emailflowwithnoselection"
