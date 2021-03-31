---
title: crmscript_ref_NSLicenseAgent_GetModuleLicenseFromDB
description: ModuleLicense GetModuleLicenseFromDB(String ownerName, String moduleName)
intellisense: NSLicenseAgent.GetModuleLicenseFromDB
keywords: NSLicenseAgent,GetModuleLicenseFromDB
so.topic: reference
---

Get license information for one particular license module.

**Parameters:**
 - **ownerName** Name of the module owner.
 - **moduleName** Name of the license module.

**Returns:** Module License details, as it is stored in the database. NULL if not found.

```crmscript
NSLicenseAgent agent;
String ownerName;
String moduleName;
ModuleLicense res = agent.GetModuleLicenseFromDB(ownerName, moduleName);
```

