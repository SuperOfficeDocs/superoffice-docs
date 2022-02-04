---
title: getCustLangCategories
uid: cs_soap_ports_customer_getcustlangcategories
description: Services SOAP interface port reference - customer getCustLangCategories
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getCustLangCategories

## Description

Retrieves all language dependant categories that are available to the customer, if the category is external. If you wish to build a tree structure you can do this manually by checking the parent IDs of each category.

If the customer language module is installed you should consider the following:

If the session key is empty the default customer language is chosen, otherwise, the system chooses the language of the customer. The external categories of the chosen language are then returned as a flat structure (but with parent ids filled out).

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid, or empty session key. If you wish to retrieve the language dependant categories for this customer a valid session key is required. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| categoryIds | An array of all external categories. Element structure is shown below |

| categoryIds element | Description |
|---|---|
| id | The category ID |
| realCategoryId | The ID of the real category this one maps to |
| name | External category name |
| parentId | The category ID of the parent. -1 if this is a top-level category, or the parent is internal. |

## Example

```csharp
string sessionKey;
customer.customerService custService = new customer.customerService();

if(custService.login("test","test", out sessionKey) == "0")
{
  customer.CategoryStruct[] categoryIds;
  string res = custService.getCustLangCategories(sessionKey, out categoryIds);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md

<!-- Referenced links -->
[1]: ../../error-codes.md
