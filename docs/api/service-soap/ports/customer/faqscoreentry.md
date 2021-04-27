---
title: cs_soap_ports_customer_faqscoreEntry
description: Services SOAP interface port reference - customer faqscoreEntry
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# faqscoreEntry

## Description

Enter a user's score into an FAQ entry. The total score is weighted of all votes.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key. If  the entry is private a valid session key is required, otherwise, the session key can be empty |
| entryId | The FAQ entry ID. |
| score | The new score. A value from 0-10 where 10 is the top score. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
customer.customerService custService = new customer.customerService(); 
string sessionKey;

if(custService.login("test","test", out sessionKey) == "0")
{
  string entryId="2";
  string score = "8";
  string res = custService.faq_scoreEntry(sessionKey,entryId,score);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
