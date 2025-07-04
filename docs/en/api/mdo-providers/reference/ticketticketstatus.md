---
uid: ticketticketstatus
title: ticketticketstatus
keywords: mdoprovider mdo provider ticketticketstatus
description: TicketTicketStatusProvider creates a flat list based on the table - TICKET_STATUS
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "ticketticketstatus" MDO List
TicketTicketStatusProvider creates a flat list based on the table: TICKET_STATUS



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketTicketStatusProvider">TicketTicketStatusProvider</see> class.
The name of the MDO list is 'ticketticketstatus'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|onlyNormal| |true|
|onlyNormalWithPostponed| |true|
|ticketType| |1|

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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketticketstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Closed||2|
|4|Deleted||4|
|5|Linked||5|
|1|Open||1|
|3|Postponed||3|


## Related MDO Lists

* "ticketticketstatusheadings"
* "ticketticketstatusheadingswithallitem"
* "ticketticketstatusheadingswithallitemwithnoselection"
* "ticketticketstatusheadingswithnoselection"
* "ticketticketstatuswithallitem"
* "ticketticketstatuswithallitemwithnoselection"
* "ticketticketstatuswithnoselection"
