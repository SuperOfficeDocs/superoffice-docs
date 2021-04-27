---
title: cs_soap_ports_customer_faqgetmostreadentries
description: Services SOAP interface port reference - customer faqgetMostReadEntries
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# faqgetMostReadEntries

## Description

Finds the most read entries in a category. The most-read entries first.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key. If empty only public entries will be listed. |
| categoryId | The category. -1 indicated root node. |
| maxEntries | Maximum number of entries to retrieve |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| faqEntries | An array of the most read entries. [See description][2]. |

## Example

```csharp
customer.customerService custService = new customer.customerService();
string sessionKey;

if(custService.login("test","test", out sessionKey) == "0")
{
  string maxEntries ="10";
  customer.FaqEntryStruct[] faqEntries;
  string res = custService.faq_getMostReadEntries(sessionKey,"-1",maxEntries, out faqEntries);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
[2]: faqgetcategory.md
