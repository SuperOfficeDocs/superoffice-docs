---
uid: crmscript_class_nspersonagent_getaddressbycountry
title: GetAddressByCountry()
description: CRMScript method in the NSPersonAgent class that gets the person's localized address
intellisense: NSPersonAgent.GetAddressByCountry
keywords: NSPersonAgent, GetAddressByCountry, GetAddressByCountry(Integer,Integer)
so.topic: reference
---

# GetAddressByCountry()

Gets the person's localized address.

Returns the address as NSLocalizedField[][].

`GetAddressByCountry(Integer personId, Integer countryId)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| personId | Integer | The person ID |
| countryId | Integer | The country ID |

## Examples

```crmscript
NSPersonAgent agent;
Integer personId;
Integer countryId;
NSAddress res = agent.GetAddressByCountry(personId, countryId);
```
