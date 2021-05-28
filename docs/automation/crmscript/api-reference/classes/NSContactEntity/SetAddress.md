---
uid: crmscript_class_nscontactentity_setaddress
title: SetAddress()
description: CRMScript method in the NSContactEntity class that sets a contact's address
intellisense: NSContactEntity.SetAddress
keywords: NSContactEntity, SetAddress, SetAddress(Address), SetAddress(NSLocalizedField[][])
so.topic: reference
---

# SetAddress()

Sets a contact's address. You can pass either an Address object or NSLocalizedField[][].

## Methods

* NSContactEntity.SetAddress(NSLocalizedField[][] address)
* NSContactEntity.SetAddress(Address address)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| address | Address OR<br>NSLocalizedField[][] | The address data to set |

## Example

```crmscript
NSContactEntity thing;
Address address;
thing.SetAddress(address);
```
