---
title: cs_soap_ports_ticket_logout
description: Services SOAP interface ticket reference logout
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# logout

## Description

Renders a session key invalid.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
{
  ticketService.logout(sessionKey);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
