---
uid: cs-soap-ports-ticket-logout
title: logout
description: Services SOAP interface ticket reference logout
keywords: ticket port, logout method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/logout
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

if (errorCode.Equals("0"))
{
  ticketService.logout(sessionKey);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
