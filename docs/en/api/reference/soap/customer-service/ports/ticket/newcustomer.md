---
uid: cs-soap-ports-ticket-newcustomer
title: newCustomer
description: Services SOAP interface ticket reference newCustomer
keywords: ticket port, newCustomer method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/newcustomer
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

if(errorCode.Equals("0"))
{
  string customerId;
  ticketService.newCustomer(sessionKey, out customerId);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
