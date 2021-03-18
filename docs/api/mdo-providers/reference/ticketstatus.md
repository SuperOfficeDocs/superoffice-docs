---
uid: ticketstatus
title: ticketstatus
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ticketstatus" MDO List
Ticket status values: Open, Closed, Inactive, Deleted, Connected



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketStatusProvider">TicketStatusProvider</see> class.
The name of the MDO list is 'ticketstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticketstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Open|||
|2|Closed|||
|3|Postponed|||
|4|Deleted|||
|5|Merged|||


## Related MDO Lists

* "ticketstatusheadings"
* "ticketstatusheadingswithallitem"
* "ticketstatusheadingswithallitemwithnoselection"
* "ticketstatusheadingswithnoselection"
* "ticketstatuswithallitem"
* "ticketstatuswithallitemwithnoselection"
* "ticketstatuswithnoselection"
