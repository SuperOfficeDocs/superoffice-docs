---
title: closeTicket
uid: cs_soap_ports_customer_closeticket
description: Services SOAP interface port reference - customer closeTicket
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
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
