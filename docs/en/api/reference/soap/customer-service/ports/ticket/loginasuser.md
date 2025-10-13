---
uid: cs-soap-ports-ticket-loginasuser
title: loginAsUser
description: Services SOAP interface ticket reference loginAsUser
keywords: ticket port, loginAsUser method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/loginasuser
---

# loginAsUser

## Description

Authenticates another user and returns a valid session key if successful. With this method, you can log in another user using your own username and password.

## In parameters

| Parameter | Description |
|---|---|
| userId | The ID of the user you want to log in |
| username | Your username |
| password | Your password |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| sessionKey | |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.loginAsUser(3, "egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  cout << "hurray!" << endl;
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
