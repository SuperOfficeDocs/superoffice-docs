---
uid: cs-soap-ports-customer-closeticket
title: closeTicket
description: Services SOAP interface port reference - customer closeTicket
keywords: customer port, closeTicket method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/customer/closeticket
---

# closeTicket

## Description

This method will close the given request if the customer has access to this. The request can either be their own or if they have company access, it can be a request of another customer in the same company.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| ticketId | The ID of the request to close |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
string sessionKey;

customer.customerService custService = new customer.customerService();

if(custService.login("test","test", out sessionKey) == "0")
{
  string res = custService.getCategories(sessionKey, "345");
  if(ret == "0")
    cout << "Request closed";
  else
    cout << "Something went wrong. Check error code";
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
