---
uid: ticketticketstatus
title: ticketticketstatus
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ticketticketstatus"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ticketticketstatus" MDO List
TicketTicketStatusProvider creates a flat list based on the table: TICKET_STATUS



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketTicketStatusProvider">TicketTicketStatusProvider</see> class.
The name of the MDO list is 'ticketticketstatus'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|onlyNormal| |true|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/ticketticketstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticketticketstatus", forceFlatList: true);
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

* "ticketticketstatusheadings"
* "ticketticketstatusheadingswithallitem"
* "ticketticketstatusheadingswithallitemwithnoselection"
* "ticketticketstatusheadingswithnoselection"
* "ticketticketstatuswithallitem"
* "ticketticketstatuswithallitemwithnoselection"
* "ticketticketstatuswithnoselection"
