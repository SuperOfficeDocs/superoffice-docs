---
uid: crmscript_ref_NSAddressSyncData_SetAddressType
title: SetAddressType(Integer addressType)
intellisense: NSAddressSyncData.SetAddressType
keywords: NSAddressSyncData, GetAddressType
so.topic: reference
---

# SetAddressType(Integer addressType)

**Parameter:** 
 - **addressType** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = ContactPostalAddress 
     - Enum: 2 = ContactStreetAddress 
     - Enum: 16387 = PersonPrivateAddress 
     - Enum: 8196 = QuoteBillingAddress 
     - Enum: 8197 = QuoteShippingAddress 

```crmscript
NSAddressSyncData thing;
Integer addressType;
thing.SetAddressType(addressType);
```

