---
title: cs_soap_ports_ticket_getticket
description: Services SOAP interface ticket reference getTicket
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getTicket

## Description

Gets data contained in a ticket/request. A set of fields that you wish to retrieve must be supplied.

**Valid fields to retrieve:**

* ticket.id
* ticket.title
* ticket.created\_at
* ticket.category
* ticket.status
* ticket.replied\_at
* ticket.closed\_at
* ticket.priority
* ticket.read\_by\_customer
* ticket.has\_attachment
* ticket.last\_changed
* ticket.cust\_id
* and any extra field.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| ticketId | The ticket ID |
| ticketFields | A list of the fields you wish to retrieve. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| ticketResult | An array containing these fields: field, type, value |
| messageIds | A list of IDs to all messages on this ticket |

## Example

```csharp
ticket.ticketService ticketService = new * ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
{
  string[] ticketFields = new string[1];
  ticketFields[0] = "ticket.title";
  ticket.ResultStruct[] ticketInfo;
  int[] messageIds;

  getTicket(sessionKey,"10",ticketFields, out ticketInfo, out messageIds);

  foreach(ticket.ResultStruct i in ticketInfo)
  {
    cout << "field:" << i.field << " value:" << i.value << endl;
  }
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
