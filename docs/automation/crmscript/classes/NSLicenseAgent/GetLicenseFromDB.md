---
uid: crmscript_ref_NSLicenseAgent_GetLicenseFromDB
title: ExtendedLicenseInfo GetLicenseFromDB(String ownerName)
intellisense: NSLicenseAgent.GetLicenseFromDB
keywords: NSLicenseAgent, GetLicenseFromDB
so.topic: reference
---

Get license, with usage, as it is stored in the database for one particular module owner.

**Parameters:**
 - **ownerName** Name of the module owner.

**Returns:** License, with usage, as it is stored in the database.

```crmscript
NSLicenseAgent agent;
String ownerName;
ExtendedLicenseInfo res = agent.GetLicenseFromDB(ownerName);
```

