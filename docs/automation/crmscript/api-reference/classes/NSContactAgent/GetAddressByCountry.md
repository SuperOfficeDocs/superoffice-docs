---
uid: crmscript_class_nscontactagent_getaddressbycountry
title: NSAddress GetAddressByCountry()
description: CRMScript method in the NSContactAgent class that gets a contact's localized address
intellisense: NSContactAgent.GetAddressByCountry
keywords: NSContactAgent, GetAddressByCountry, GetAddressByCountry(Integer,Integer)
so.topic: reference
---

# GetAddressByCountry()

Gets the contact's localized address (NSLocalizedField[][]).

`NSAddress GetAddressByCountry(Integer contactId, Integer countryId)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| contactId | Integer | The contact ID |
| countryId | Integer | The country ID |

## Examples

```crmscript
NSContactAgent agent;
Integer contactId;
Integer countryId;
NSAddress res = agent.GetAddressByCountry(contactId, countryId);
```
