---
uid: crmscript_ref_NSLicenseAgent_GetShopUrl
title: String GetShopUrl(String ownerName)
intellisense: NSLicenseAgent.GetShopUrl
keywords: NSLicenseAgent, GetShopUrl
so.topic: reference
---

# String GetShopUrl(String ownerName)

Get the shop URL for the specified module owner. This can be used to redirect user to the web shop.

**Parameters:**
 - **ownerName** Name of the module owner.

**Returns:** String

```crmscript
NSLicenseAgent agent;
String ownerName;
String res = agent.GetShopUrl(ownerName);
```

