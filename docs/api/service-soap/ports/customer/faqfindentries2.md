---
title: faqfindEntries2
uid: cs_soap_ports_customer_faqfindentries2
description: Services SOAP interface port reference - customer faqfindEntries2
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# faqfindEntries2

## Description

This method will search for FAQ entries. The search words are given as a string, and the system will find the best entries based on that string.

For each specified category, at most 10 entries will be found. The method will search in all the given categories and subcategories. If duplicates are found, only one occurrence will be shown.

[!include[ALT](./includes/note-db-update.md)]

[!include[ALT](./includes/ejournalcron-force.md)]

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key. If empty only public FAQ entries will be found. |
| searchWords | A space-separated list of words that you wish to search for. |
| categoryIds | An array of the ID of the top node categories you wish to search below. All subcategories will be searched too.<br>"-1" = search the whole tree<br>"0" = the root node of the language of the user will be used (only when the customer language module is installed). |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| faqEntries | An array of the faq entries. The struct that is returned contains the elements below. |

| faqEntries element | Description |
|---|---|
| id | The FAQ entry ID |
| question | The question. |
| title | Title of the entry. |
| hasHtml | 1 if this FAQ entry is HTML formatted, 0 if it is plain text. |
| score | The score this entry has achieved. |
| fullName | The name of the entry including all parent folders. |
| parentId | The ID of the folder this entry is stored in. -1 if top node. |

## Example

```csharp
customer.customerService custService = new customer.customerService();

string sessionKey;
if(custService.login("test","test", out sessionKey) == "0")
{
  customer.FaqEntryStruct[] myFaqEntries;
  string[] categoryIds = new string[2];
  categoryIds[0] = "1";
  categoryIds[1] = "2";
  string ret = custService.faq_findEntries2(sessionKey, "public", categoryIds, out myFaqEntries);
  if(ret == "0")
    //myFaqEntries now contains the results.
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
