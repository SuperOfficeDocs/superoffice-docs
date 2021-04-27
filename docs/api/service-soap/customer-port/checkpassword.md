---
title: cs_soap_ports_customer_checkpassword
description: Services SOAP interface port reference - customer checkPassword
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# checkPassword

## Description

Checks if this user name and password are valid login credentials. Will return `SoapErrorIncorrectLoginCustomer` error code if not correct.

## In parameters

| Parameter | Description |
|---|---|
| username | The user name |
| password | The password |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
customer.customerService custService = new customer.customerService();

string ret = custService.checkPassword("username","password");

if(ret == "0")
  cout << "Hip hurray";
else
  cout << "Oh no";
```

<!-- Referenced links -->
[1]: ../error-codes.md
