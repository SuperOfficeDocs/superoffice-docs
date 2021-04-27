---
title: cs_soap_ports_customer_ faqgetcategory
description: Services SOAP interface port reference - customer faqgetCategory
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# faqgetCategory

## Description

Retrieves information about an FAQ category

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key. If empty the category has to be public. |
| categoryId - The ID of the category. -1 if you want the top node |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| faqSubCategories | All subcategories. Every structure contains the following fields:<br>id (The category ID)<br>name (The category name)<br>description (The description of this category) |
| faqEntries | All FAQ entries in this category. [See field description][2]. |
| faqParents | The parents listed in a top/down matter: topCategory, notSoTopCategory, ..., thisCategory<br>id (The category ID)<br>name (The category name) |
| faqGroups | The groups contained in this category. Every group contains the following information: |

| faqGroup | Description |
|---|---|
| description | The description of the group |
| id | The group ID of this group. Used in [faq\_getGroupEntries()][3]. |
| entries | The FAQ entries in this group. Each entry contains the following information:<br>id (The FAQ entry ID)<br>question (The question in the entry ) |

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

  string ret = custService.faq_getCategory(sessionKey, "2", out categories, out entries, out parents, out groups);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
[2]: faqfindEntries2.md
