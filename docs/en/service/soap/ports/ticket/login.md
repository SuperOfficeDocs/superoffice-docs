---
title: login
uid: cs_soap_ports_ticket_login
description: Services SOAP interface ticket reference login
author: SuperOffice Product and Engineering
keywords: soap
date: 01.25.2021
content_type: reference
---

# login

## Description

Authenticates a user and returns a valid session key if successful.

## In parameters

| Parameter | Description |
|---|---|
| userName | A user's valid name |
| password | A user's valid password |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| sessionKey | |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  cout << "hurray!" << endl;
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
