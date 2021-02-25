---
title: cs_soap_ports_customer_getlanguages
description: Services SOAP interface port reference - customer getLanguages
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getLanguages

## Description

Retrieves all available customer languages in the system. If the customer language module is not installed an error is returned.

## Out parameters

| Parameter | Description |
|---|---|
|languageEntries | A list of all languages containing the following info:<br>languageCode (en/no/dk/se etc)<br>languageName (English/Norsk etc)<br>virtualDomain – The domain associated with this language’s customer pages |

## Example

```csharp
string sessionKey;
customer.customerService custService = new customer.customerService();
customer.LanguagesStruct tmpLangStruct[];
custService.getLanguages(tmpLangStruct);

foreach(customer.LanguagesStruct i in tmpLangStruct)
{
  textBox1.text i.languageName;
}
```

<!-- Referenced links -->
[1]: ../error-codes.md

<!-- Referenced links -->
[1]: ../error-codes.md
