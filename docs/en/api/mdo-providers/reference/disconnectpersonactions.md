---
uid: disconnectpersonactions
title: disconnectpersonactions
keywords: mdoprovider mdo provider disconnectpersonactions
description: List of actions to perform when disconnecting a contact from a company
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("disconnectpersonactions", forceFlatList: true);
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
