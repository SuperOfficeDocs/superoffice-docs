---
uid: crmscript_ref_NSLicenseAgent_GetLicenseStatusFromLicenseServer
title: CheckLicenseStatusResult GetLicenseStatusFromLicenseServer(String ownerName)
intellisense: NSLicenseAgent.GetLicenseStatusFromLicenseServer
keywords: NSLicenseAgent, GetLicenseStatusFromLicenseServer
so.topic: reference
---

Get License from the license server for a particular module owner.

**Parameters:**
 - **ownerName** Name of the module owner to get license from.

**Returns:** License from the database, from the license server and with usage.

```crmscript
NSLicenseAgent agent;
String ownerName;
CheckLicenseStatusResult res = agent.GetLicenseStatusFromLicenseServer(ownerName);
```

