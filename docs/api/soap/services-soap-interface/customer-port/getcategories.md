---
title: cs_soap_ports_customer_getcategories
description: Services SOAP interface port reference - customer getCategories
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getCategories

## Description

Retrieves all categories that are available to the customer, if the category is external. If you wish to build a tree structure you can do this manually by checking the parent IDs of each category.

If the customer language module is installed you should consider the following:

If the session key is empty the default customer language is chosen, otherwise, the system chooses the language of the customer. If this language has any external categories defined, these are returned as a flat structure (all nodes have parent = -1), otherwise, the tree structure of all external categories is returned as above.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid, or empty session key. If you wish to retrieve the language dependant categories for this customer a valid session key is required. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| categoryIds | An array of all external categories. Elements of this structure are as follows:<br>id (The category ID)<br>name (External category name)<br>parentId (The category ID of the parent. -1 if this is a top level category.) |

## Example

```csharp
string sessionKey;
customer.customerService custService = new customer.customerService();

if(custService.login("test","test", out sessionKey) == "0")
{
  customer.CategoryStruct[] categoryIds;
  string res = custService.getCategories(sessionKey, out categoryIds);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md

<!-- Referenced links -->
[1]: ../error-codes.md
