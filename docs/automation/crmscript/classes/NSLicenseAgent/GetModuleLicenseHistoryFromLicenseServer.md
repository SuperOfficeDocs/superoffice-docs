---
title: crmscript_ref_NSLicenseAgent_GetModuleLicenseHistoryFromLicenseServer
description: String GetModuleLicenseHistoryFromLicenseServer(ExtendedLicenseInfo licenseInfo, ExtendedModuleLicense moduleLicense)
intellisense: NSLicenseAgent.GetModuleLicenseHistoryFromLicenseServer
keywords: NSLicenseAgent,GetModuleLicenseHistoryFromLicenseServer
so.topic: reference
---

Get details about a license from the license server.

**Parameters:**
 - **licenseInfo** Description of the license
 - **moduleLicense** Information about a particular module to get information for.

**Returns:** Information about a particular license module.

```crmscript
NSLicenseAgent agent;
ExtendedLicenseInfo licenseInfo;
ExtendedModuleLicense moduleLicense;
String res = agent.GetModuleLicenseHistoryFromLicenseServer(licenseInfo, moduleLicense);
```

