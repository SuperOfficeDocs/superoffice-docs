---
uid: crmscript_ref_NSLicenseAgent_GetUserLicenses
title: NSLicenseOwner[] GetUserLicenses(Integer associateId)
intellisense: NSLicenseAgent.GetUserLicenses
keywords: NSLicenseAgent, GetUserLicenses
so.topic: reference
---

# NSLicenseOwner[] GetUserLicenses(Integer associateId)

Obtain information about associate module licenses

**Parameters:**
 - **associateId** Associate id to check for associate module licenses

**Returns:** NSLicenseOwner[]

```crmscript
NSLicenseAgent agent;
Integer associateId;
NSLicenseOwner[] res = agent.GetUserLicenses(associateId);
```

