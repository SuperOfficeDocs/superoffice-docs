---
uid: ticket
title: ticket
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ticket"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ticket" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketListProvider">TicketListProvider</see> class.
The name of the MDO list is 'ticket'.




## Sample Request

```http!
GET /api/v1/MDOList/ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticket", forceFlatList: true);
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

* "ticketheadings"
* "ticketheadingswithallitem"
* "ticketheadingswithallitemwithnoselection"
* "ticketheadingswithnoselection"
* "ticketwithallitem"
* "ticketwithallitemwithnoselection"
* "ticketwithnoselection"
