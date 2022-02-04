---
title: faqgetGroupEnties
uid: cs_soap_ports_customer_faqgetGroupEnties
description: Services SOAP interface port reference - customer faqgetGroupEnties
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# faqgetGroupEnties

## Description

Gets entry information about all entries in an faq group. Useful if you wish to display all questions with answers for a group in a separate element/page.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key. If empty only public entries will be accessible. |
| groupId | The group ID |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| entries | All entries in a group. [See field description][2]. |

## Example

```csharp
customer.customerService custService = new customer.customerService();
string sessionKey;

if(custService.login("test","test", out sessionKey) == "0")
{
  customer.FaqCategoryStruct[] categories;
  customer.FaqEntryStruct[] entries;
  customer.FaqParentStruct[] parents;
  customer.FaqGroupStruct[] groups;
  string ret = custService.faq_getCategory(sessionKey, "2",out categories,out entries,out parents,out groups);
  out attachmentIds,out hasHtml,out score,out faqParents);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
[2]: faqfindEntries2.md