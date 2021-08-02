---
uid: crmscript_ref_NSLicenseAgent_GetLicenseStatusFromLicenseServer
title: NSCheckLicenseStatusResult GetLicenseStatusFromLicenseServer(String ownerName)
intellisense: NSLicenseAgent.GetLicenseStatusFromLicenseServer
keywords: NSLicenseAgent, GetLicenseStatusFromLicenseServer
so.topic: reference
---

Get License from the license server for a particular module owner.

**Parameters:**
 - **ownerName** Name of the module owner to get license from.

**Returns:** NSCheckLicenseStatusResult

```crmscript
NSLicenseAgent agent;
String ownerName;
NSCheckLicenseStatusResult res = agent.GetLicenseStatusFromLicenseServer(ownerName);
```

