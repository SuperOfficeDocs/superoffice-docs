---
title: cs_soap_ports_customer_faqfindentries
description: Services SOAP interface port reference - customer faqfindEntries
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# faqfindEntries

## Description

> [!NOTE]
> Deprecated, see [faq\_findEntries2()][2].

This method will search for a FAQ entry. The search words are given as a string, and the system will find the best entries based on that string. The method will find at most 10 entries.

[!include[ALT](./includes/note-db-update.md)]

[!include[ALT](./includes/ejournalcron-force.md)]

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key. If empty only public FAQ entries will be found. |
| searchWords | A space-separated list of words that you wish to search for. |
| categoryId - The ID of the top node category you wish to search below. All subcategories will be searched too.<br>"-1" = search the whole tree<br>"0" = the root node of the language of the user will be used (only when the customer language module is installed). |

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
  string ret = custService.faq_findEntries(sessionKey, "public", "-1", out myFaqEntries);
  if(ret == "0")
    //myFaqEntries now contains the results.
}
```

<!-- Referenced links -->
[1]: ../error-codes.md

<!-- Referenced links -->
[1]: ../error-codes.md
[2]: faqfindEntries2.md
