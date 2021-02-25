---
title: cs_soap_ports_ticket_newcompany
description: Services SOAP interface ticket reference newCompany
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# newCompany

## Description

Creates a new empty company.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| name | Name of compnay |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| companyId | The ID of the new company |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if(errorCode.Equals("0")
{
  string companyId;
  string companyName = "Liberty Communications";
  ticketService.newCompany(sessionKey,  companyName, out companyId);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
