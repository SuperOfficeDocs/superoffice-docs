---
title: cs_soap_ports_customer_logout
description: Services SOAP interface port reference - customer logout
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# logout

## Description

This method is used to log out a customer, and thus making the session key invalid for further use. You should always log out a customer when you have finished a session.

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
customer.customerService custService = new customer.customerService();

string ret = custService.logout(sessionKey);
```

<!-- Referenced links -->
[1]: ../../error-codes.md
