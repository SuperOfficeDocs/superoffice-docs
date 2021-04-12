---
uid: disconnectpersonactions
title: disconnectpersonactions
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "disconnectpersonactions"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "disconnectpersonactions" MDO List
List of actions to perform when disconnecting a contact from a company



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DisconnectPersonActionsProvider">DisconnectPersonActionsProvider</see> class.
The name of the MDO list is 'disconnectpersonactions'.




## Sample Request

```http!
GET /api/v1/MDOList/disconnectpersonactions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("disconnectpersonactions", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Do not move activities|||
|2|Move all activities|||
|3|Move all activities starting after|||


## Related MDO Lists

* "disconnectpersonactionsheadings"
* "disconnectpersonactionsheadingswithallitem"
* "disconnectpersonactionsheadingswithallitemwithnoselection"
* "disconnectpersonactionsheadingswithnoselection"
* "disconnectpersonactionswithallitem"
* "disconnectpersonactionswithallitemwithnoselection"
* "disconnectpersonactionswithnoselection"
