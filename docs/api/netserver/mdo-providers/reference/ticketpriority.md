---
uid: ticketpriority
title: ticketpriority
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ticketpriority"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ticketpriority" MDO List
MDO list provider for ticket priorities.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketPriorityListProvider">TicketPriorityListProvider</see> class.
The name of the MDO list is 'ticketpriority'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketpriority
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticketpriority", forceFlatList: true);
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

* "ticketpriorityheadings"
* "ticketpriorityheadingswithallitem"
* "ticketpriorityheadingswithallitemwithnoselection"
* "ticketpriorityheadingswithnoselection"
* "ticketprioritywithallitem"
* "ticketprioritywithallitemwithnoselection"
* "ticketprioritywithnoselection"
