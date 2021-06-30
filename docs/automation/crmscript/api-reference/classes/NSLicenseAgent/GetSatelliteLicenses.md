---
uid: crmscript_ref_NSLicenseAgent_GetSatelliteLicenses
title: LicenseOwner[] GetSatelliteLicenses(Integer satelliteId)
intellisense: NSLicenseAgent.GetSatelliteLicenses
keywords: NSLicenseAgent, GetSatelliteLicenses
so.topic: reference
---

Obtain information about satellite module licenses

**Parameters:**
 - **satelliteId** Satellite id to check for satellite module licenses

**Returns:** Satellite module licenses grouped by owners.

```crmscript
NSLicenseAgent agent;
Integer satelliteId;
LicenseOwner[] res = agent.GetSatelliteLicenses(satelliteId);
```

