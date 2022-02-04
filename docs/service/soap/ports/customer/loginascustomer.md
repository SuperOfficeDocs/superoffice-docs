---
title: loginAsCustomer
uid: cs_soap_ports_customer_loginascustomer
description: Services SOAP interface port reference - customer loginAsCustomer
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# loginAsCustomer

## Description

This method is used to log in a customer, but instead of using the customer's password, you use your SuperOffice username and password for verification.

## In parameters

| Parameter | Description |
|---|---|
| username | Your SuperOffice username |
| password | Your SuperOffice password |
| customerUsername |  The username of the customer |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | 0 = successful login, 1 = incorrect login |
| sessionKey | The generated session key |

## Example

```csharp
customer.customerService custService = new customer.custmerService();
string sessionKey;

string ret = custService.loginAsCustomer("john", "pw", "johndoe", out sessionKey);
```

<!-- Referenced links -->
[1]: ../../error-codes.md
