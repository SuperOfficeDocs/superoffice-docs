---
title: cs_soap_ports_ticket_getactiveticketsstatus
description: Services SOAP interface ticket reference getActiveTicketsStatus
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getActiveTicketsStatus

## Description

Returns all active tickets for the user and their read/unread status.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| ticketStatusResult - An array containing the active tickets:<br>ticketId<br>readStatus – {1=green (read), 2=yellow(new info), 3=red(unread)} |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
{
  ticket.ActiveTicketsStruct[] tickets;

  getActiveTicketsStatus(sessionKey, out tickets);

  foreach(ticket.ActiveTicketsStruct i in tickets)
  {
    cout << "ticket ID:" << i.ticketId << endl;
    cout << "read status:" << i.readStatus << endl;
  }
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
