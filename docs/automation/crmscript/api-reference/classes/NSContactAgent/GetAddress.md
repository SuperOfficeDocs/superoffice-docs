---
uid: crmscript_class_nscontactagent_getaddress
title: NSAddress GetAddress(Integer contactId)
description: CRMScript method in the NSContactAgent class that gets a contact's localized address
intellisense: NSContactAgent.GetAddress
keywords: NSContactAgent, GetAddress, GetAddress(Integer)
so.topic: reference
---

# GetAddress()

Gets the contact's localized address (NSLocalizedField[][]).

`NSAddress GetAddress(Integer contactId)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| contactId | Integer |  The contact ID |

## Examples

```crmscript
NSContactAgent agent;
Integer contactId;
NSAddress res = agent.GetAddress(contactId);
```
