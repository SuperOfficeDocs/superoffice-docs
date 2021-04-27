---
title: cs_soap_ports_ticket_newcustomer
description: Services SOAP interface ticket reference newCustomer
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# newCustomer

## Description
Creates a new empty customer.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| customerId | The Id of the new customer |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if(errorCode.Equals("0")
{
  string customerId;
  ticketService.newCustomer(sessionKey, out customerId);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
