---
title: cs_soap_ports_ticket_setuseridletime
description: Services SOAP interface ticket reference setUserIdleTime
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# setUserIdleTime

## Description

Sets the number of seconds a user has been idle (no inputs from keyboard or mouse). This is used to automatically set users to idle so they do not receive any new chat sessions.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| idleTime | Seconds user has been idle |

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
  int it = GetUserIdleTime() //your own method for finding idle time
  ticketService.setUserIdleTime(sessionKey, idleTime);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
