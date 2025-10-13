---
uid: cs-soap-ports-customer-getlanguages
title: getLanguages
description: Services SOAP interface port reference - customer getLanguages
keywords: customer port, getLanguages method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/customer/getlanguages
---

# getLanguages

## Description

Retrieves all available customer languages in the system. If the customer language module is not installed an error is returned.

## Out parameters

| Parameter | Description |
|---|---|
|languageEntries | A list of all languages containing the following info:<br />languageCode (en/no/dk/se etc)<br />languageName (English/Norsk etc)<br />virtualDomain – The domain associated with this language’s customer pages |

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

<!-- Referenced links -->
