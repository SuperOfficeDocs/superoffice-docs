---
uid: crmscript_ref_NSLicenseAgent_GetUserLicenses
title: LicenseOwnerArray GetUserLicenses(Integer associateId)
intellisense: NSLicenseAgent.GetUserLicenses
keywords: NSLicenseAgent, GetUserLicenses
so.topic: reference
---

Obtain information about associate module licenses

**Parameters:**
 - **associateId** Associate id to check for associate module licenses

**Returns:** Associate module licenses grouped by owners.

```crmscript
NSLicenseAgent agent;
Integer associateId;
LicenseOwnerArray res = agent.GetUserLicenses(associateId);
```

