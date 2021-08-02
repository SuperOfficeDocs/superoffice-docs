---
uid: crmscript_ref_NSLicenseAgent_GetModuleLicenseFromDB
title: NSModuleLicense GetModuleLicenseFromDB(String ownerName, String moduleName)
intellisense: NSLicenseAgent.GetModuleLicenseFromDB
keywords: NSLicenseAgent, GetModuleLicenseFromDB
so.topic: reference
---

Get license information for one particular license module.

**Parameters:**
 - **ownerName** Name of the module owner.
 - **moduleName** Name of the license module.

**Returns:** NSModuleLicense

```crmscript
NSLicenseAgent agent;
String ownerName;
String moduleName;
NSModuleLicense res = agent.GetModuleLicenseFromDB(ownerName, moduleName);
```

