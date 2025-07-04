---
title: sendPassword
uid: cs_soap_ports_customer_sendpassword
description: Services SOAP interface port reference - customer sendPassword
author: SuperOffice Product and Engineering
keywords: soap
date: 01.25.2021
content_type: reference
---

# sendPassword

## Description

This method will send the username and password to the given email address (if it exists). The actual text sent is configured in SuperOffice (Settings->System).

## In parameters

| Parameter | Description |
|---|---|
| emailCode | The email address of the customer to send the password |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
customer.customerService custService = new customer.customerService();
string errorCode = custService.login("johndoe","pw",out sessionKey);

if(errorCode.Equals("0"))
{
  string ret = custService.sendPassword("test@mycompany.com");
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md

<!-- Referenced links -->