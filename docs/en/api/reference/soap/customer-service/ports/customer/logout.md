---
uid: cs-soap-ports-customer-logout
title: logout
description: Services SOAP interface port reference - customer logout
keywords: customer port, logout method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/customer/logout
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
