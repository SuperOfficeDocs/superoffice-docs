---
uid: crmscript_ref_NSLicenseAgent_GetSatelliteLicenses
title: NSLicenseOwner[] GetSatelliteLicenses(Integer satelliteId)
intellisense: NSLicenseAgent.GetSatelliteLicenses
keywords: NSLicenseAgent, GetSatelliteLicenses
so.topic: reference
---

Obtain information about satellite module licenses

**Parameters:**
 - **satelliteId** Satellite id to check for satellite module licenses

**Returns:** NSLicenseOwner

```crmscript
NSLicenseAgent agent;
Integer satelliteId;
NSLicenseOwner[] res = agent.GetSatelliteLicenses(satelliteId);
```

