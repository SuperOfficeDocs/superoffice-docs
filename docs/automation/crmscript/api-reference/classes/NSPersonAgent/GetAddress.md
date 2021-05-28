---
uid: crmscript_class_nspersonagent_getaddress
title: GetAddress()
description: CRMScript method in the NSPersonAgent class that gets the person's localized address
intellisense: NSPersonAgent.GetAddress
keywords: NSPersonAgent, GetAddress, GetAddress(Integer)
so.topic: reference
---

# GetAddress()

Gets the person's localized address.

Returns the address as LocalizedField[][].

`GetAddress(Integer personId)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| personId | Integer | The person ID |

## Examples

```crmscript
NSPersonAgent agent;
Integer personId;
Address res = agent.GetAddress(personId);
```
