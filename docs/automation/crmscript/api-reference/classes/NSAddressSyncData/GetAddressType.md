---
uid: crmscript_ref_NSAddressSyncData_GetAddressType
title: Integer GetAddressType()
intellisense: NSAddressSyncData.GetAddressType
keywords: NSAddressSyncData, GetAddressType
so.topic: reference
---

# Integer GetAddressType()

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = ContactPostalAddress 
     - Enum: 2 = ContactStreetAddress 
     - Enum: 16387 = PersonPrivateAddress 
     - Enum: 8196 = QuoteBillingAddress 
     - Enum: 8197 = QuoteShippingAddress 

```crmscript
NSAddressSyncData thing;
Integer addressType  = thing.GetAddressType();
```

