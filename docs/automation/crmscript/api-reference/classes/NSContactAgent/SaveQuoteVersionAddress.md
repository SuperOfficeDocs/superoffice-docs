---
uid: crmscript_ref_NSContactAgent_SaveQuoteVersionAddress
title: NSAddress SaveQuoteVersionAddress(Integer quoteVersionId, NSAddress address, Integer addressType, Integer countryId)
intellisense: NSContactAgent.SaveQuoteVersionAddress
keywords: NSContactAgent, SaveQuoteVersionAddress
so.topic: reference
---

# NSAddress SaveQuoteVersionAddress(Integer quoteVersionId, NSAddress address, Integer addressType, Integer countryId)

Save a custom quote version address.

**Parameters:**
 - **quoteVersionId** The version to save the address on.
 - **address** The address to save on the quote version.
 - **addressType** Should be either QuoteBillingAddress or QuoteShippingAddress
     - Enum: 0 = Unknown 
     - Enum: 1 = ContactPostalAddress 
     - Enum: 2 = ContactStreetAddress 
     - Enum: 16387 = PersonPrivateAddress 
     - Enum: 8196 = QuoteBillingAddress 
     - Enum: 8197 = QuoteShippingAddress 
 - **countryId** The country for the custom address

**Returns:** NSAddress

```crmscript
NSContactAgent agent;
Integer quoteVersionId;
NSAddress address;
Integer addressType;
Integer countryId;
NSAddress res = agent.SaveQuoteVersionAddress(quoteVersionId, address, addressType, countryId);
```

