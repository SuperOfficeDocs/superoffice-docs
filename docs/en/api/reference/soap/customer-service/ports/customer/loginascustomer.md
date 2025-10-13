---
uid: cs-soap-ports-customer-loginascustomer
title: loginAsCustomer
description: Services SOAP interface port reference - customer loginAsCustomer
keywords: customer port, loginAsCustomer method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/customer/loginascustomer
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
