---
uid: crmscript_class_nspersonentity_getaddress
title: NSAddress GetAddress()
description: CRMScript method in the NSPersonEntity class that retrieves a formatted address
intellisense: NSPersonEntity.GetAddress
keywords: NSPersonEntity, GetAddress, GetAddress()
so.topic: reference
---

# GetAddress()

Retrieves the structure holding formatted address data. The layout of the array structure indicates the layout of the localized address.

`NSAddress GetAddress()`

## Example

```crmscript
NSPersonEntity thing;
NSAddress address  = thing.GetAddress();
```
