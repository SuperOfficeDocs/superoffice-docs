---
uid: crmscript_class_nspersonentity_setaddress
title: SetAddress()
description: CRMScript method in the NSPersonEntity class that sets a formatted address
intellisense: NSPersonEntity.SetAddress
keywords: NSPersonEntity, GetAddress, SetAddress(NSLocalizedField[][])
so.topic: reference
---

# SetAddress()

Sets the structure holding formatted address data. The layout of the array structure indicates the layout of the localized address.

## Parameters

| Parameter | Type | Description |
|---|---|---|
| address | NSAddress | |

```crmscript
NSPersonEntity thing;
NSAddress address;
thing.SetAddress(address);
```
