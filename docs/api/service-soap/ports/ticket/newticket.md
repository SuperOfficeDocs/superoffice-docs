---
title: newTicket
uid: cs_soap_ports_ticket_newticket
description: Services SOAP interface  ticket reference newTicket
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# newTicket

## Description

Creates a new ticket. To add messages to this ticket you need to use `addMessage3()`.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| title | Title of the new ticket |
| sLevel | Security level. 1= Internal, 2=External |
| categoryId | Cateogry ID of the new ticket |
| priorityId | The ID of the priority of this ticket. If -1 the priority will be chosen based on the priority of the customer or company |
| owner | The user who should own this message. -1 will automatically assign an owner based on delegation rules in the cateogry and 1 will make the ticket unassigned. |
| customers | A list of the ids to customers associated with this ticket/request. The first customer will be the primary customer. |
| extraFields | A list of field/value structs with values for extra fields. The fields are on the form "ticket.x_10" where 10 is the extra field ID. |
| sendNotification | If set to true, the user will receive a notification specified by his user settings. False will not send any notifications |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| ticketId | The Id of the new ticket |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
{
  string[] custIds = new string[1];
  custIds[0] = "5";

  ticket.ValuePairStruct[] extraFields = new ticket.ValuePairStruct[1];
  extraFields[0] = new ticket.ValuePairStruct();
  extraFields[0].field = "ticket.x_24";
  extraFields[0].value = "1234";

  string ticketId;

  ticketService.newTicket(sessionKey,
   "New Soap Ticket",
   "2",
   "4",
   "-1",   //automatically find priority
   "-1",   //automatically assign owner
   custIds,
   extraFields,
   true,
   out ticketId);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
