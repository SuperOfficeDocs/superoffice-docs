---
title: cs_soap_ports_customer_getcategory
description: Services SOAP interface port reference - customer getCategory
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getCategory

## Description

Retrieves the category with the given ID. The category has to be available for the customer to get information about it (depends on if the category is external/internal. This can be overridden if the customer language module is installed).

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid, or empty session key. If you wish to retrieve the language dependant categories for this customer a valid session key is required. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| category | The category with the given ID. The structure is as follows:<br>id (The category ID)<br>name (External category name)<br>parentId (The category ID of the parent. -1, if this is a top-level category or the parent is internal.) |

## Example

```csharp
string sessionKey;
customer.customerService custService = new customer.customerService();

if(custService.login("test","test", out sessionKey) == "0")
{
  customer.CategoryStruct category;
  string res = custService.getCategory(sessionKey, out category);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md

<!-- Referenced links -->
[1]: ../error-codes.md
