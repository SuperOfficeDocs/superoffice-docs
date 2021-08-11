---
uid: crmscript_ref_NSSatellite_GetLicenseOwners
title: NSLicenseOwner[] GetLicenseOwners()
intellisense: NSSatellite.GetLicenseOwners
keywords: NSSatellite, GetLicenseOwners
so.topic: reference
---

# NSLicenseOwner[] GetLicenseOwners()

The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user

**Returns:** NSLicenseOwner[]

```crmscript
NSSatellite thing;
NSLicenseOwner[] licenseOwners  = thing.GetLicenseOwners();
```

