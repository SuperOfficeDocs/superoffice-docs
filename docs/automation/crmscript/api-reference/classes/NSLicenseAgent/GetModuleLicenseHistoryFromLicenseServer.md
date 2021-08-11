---
uid: crmscript_ref_NSLicenseAgent_GetModuleLicenseHistoryFromLicenseServer
title: String GetModuleLicenseHistoryFromLicenseServer(NSExtendedLicenseInfo licenseInfo, NSExtendedModuleLicense moduleLicense)
intellisense: NSLicenseAgent.GetModuleLicenseHistoryFromLicenseServer
keywords: NSLicenseAgent, GetModuleLicenseHistoryFromLicenseServer
so.topic: reference
---

# String GetModuleLicenseHistoryFromLicenseServer(NSExtendedLicenseInfo licenseInfo, NSExtendedModuleLicense moduleLicense)

Get details about a license from the license server.

**Parameters:**
 - **licenseInfo** Description of the license
 - **moduleLicense** Information about a particular module to get information for.

**Returns:** String

```crmscript
NSLicenseAgent agent;
NSExtendedLicenseInfo licenseInfo;
NSExtendedModuleLicense moduleLicense;
String res = agent.GetModuleLicenseHistoryFromLicenseServer(licenseInfo, moduleLicense);
```

