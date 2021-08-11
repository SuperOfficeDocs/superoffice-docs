---
uid: crmscript_ref_NSLicenseAgent_GetLicenseFromDB
title: NSExtendedLicenseInfo GetLicenseFromDB(String ownerName)
intellisense: NSLicenseAgent.GetLicenseFromDB
keywords: NSLicenseAgent, GetLicenseFromDB
so.topic: reference
---

# NSExtendedLicenseInfo GetLicenseFromDB(String ownerName)

Get license, with usage, as it is stored in the database for one particular module owner.

**Parameters:**
 - **ownerName** Name of the module owner.

**Returns:** NSExtendedLicenseInfo

```crmscript
NSLicenseAgent agent;
String ownerName;
NSExtendedLicenseInfo res = agent.GetLicenseFromDB(ownerName);
```

