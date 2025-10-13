---
uid: cs-soap-ports-ticket-findcustomerfromemail
title: findCustomerFromEmail
description: Services SOAP interface ticket reference  findCustomerFromEmail
keywords: ticket port, findCustomerFromEmail method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/findcustomerfromemail
---

# findCustomerFromEmail

## Description

> [!CAUTION]
> Deprecated: use `findCustomers()` instead.

## In parameters

| Parameter | Description |
|---|---|
| username | The username of a SuperOffice administrator |
| password | The password of a SuperOffice administrator |
| custEmail | The email address of the customer to find |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| custUsername | The username of the customer if found |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string custUsername;
string errorCode = ticketService.findCustomerFromEmail("myUser", "myPwd", "customer@domain.com", out custUsername);

if (errorCode.Equals("0"))
  cout << custUsername; // Here we have the username
```

<!-- Referenced links -->
[1]: ../../error-codes.md
