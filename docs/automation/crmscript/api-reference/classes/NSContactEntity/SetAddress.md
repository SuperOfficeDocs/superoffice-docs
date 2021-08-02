---
uid: crmscript_class_nscontactentity_setaddress
title: SetAddress()
description: CRMScript method in the NSContactEntity class that sets a contact's address
intellisense: NSContactEntity.SetAddress
keywords: NSContactEntity, SetAddress, SetAddress(NSAddress), SetAddress(NSLocalizedField[][])
so.topic: reference
---

# SetAddress()

Sets a contact's address. You can pass either an NSAddress object or NSLocalizedField[][].

## Methods

* NSContactEntity.SetAddress(NSLocalizedField[][] address)
* NSContactEntity.SetAddress(NSAddress address)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| address | NSAddress OR<br>NSLocalizedField[][] | The address data to set |

## Example

```crmscript
NSContactEntity thing;
NSAddress address;
thing.SetAddress(address);
```
