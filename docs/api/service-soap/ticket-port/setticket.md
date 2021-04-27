---
title: cs_soap_ports_ticket_setticket
description: Services SOAP interface ticket reference setTicket
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# setTicket

## Description

Sets the value of one or more fields on a ticket.

**Valid fields:**

* ticket.category
* ticket.owner
* ticket.title
* ticket.status (open, close, delete)
* ticket.customerId (-1 will delete all connected customers, any other id will add it)
* ticket.filterAddress (replies will use this as From-address)
* ticket.filterAddress
* ticket.createdAt
* ticket.slevel (1=internal, 2=external)
* ticket.dbiAgentId
* ticket.dbiKey
* ticket.dbiLastSynchronized
* And all extra fields.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| ticketId | The ticket ID |
| ticketValues | An array of field/value structs |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "banken", out sessionKey);

if (errorCode.Equals("0")
{
  ticket.ValuePairStruct[] values = new ticket.ValuePairStruct[1];

  values[0] = new ticket.ValuePairStruct();
  values[0].field = "ticket.title";
  values[0].value = "New title";

  ticketService.setTicket(sessionKey,"70", values);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
