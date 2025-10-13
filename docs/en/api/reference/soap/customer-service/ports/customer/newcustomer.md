---
uid: cs-soap-ports-customer-newcustomer
title: newCustomer
description: Services SOAP interface port reference - customer newCustomer
keywords: customer port, newCustomer method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/customer/newcustomer
---

# newCustomer

## Description

This method will create a new customer with the specified user name and password. You have to log in the customer afterward to use more methods by using the `login` method. If you want to specify more values than the user name and password, log them in after this method, and use the `setCustomer` method to set any other value.

## In parameters

| Parameter | Description |
|---|---|
| userName | The user name of the new user |
| password | The password of the new user |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
customer.customerService custService = new customer.customerService();
string ret = custService.newCustomer("Billy", "pass");

if (ret.Equals("0"))
  //Ok, customer created
```

<!-- Referenced links -->
[1]: ../../error-codes.md
