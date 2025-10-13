---
uid: cs-soap-ports-ticket-login
title: login
description: Services SOAP interface ticket reference login
keywords: ticket port, login method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/login
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
