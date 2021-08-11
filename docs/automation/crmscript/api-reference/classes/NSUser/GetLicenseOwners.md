---
uid: crmscript_ref_NSUser_GetLicenseOwners
title: NSLicenseOwner[] GetLicenseOwners()
intellisense: NSUser.GetLicenseOwners
keywords: NSUser, GetLicenseOwners
so.topic: reference
---

# NSLicenseOwner[] GetLicenseOwners()

The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user

**Returns:** NSLicenseOwner[]

```crmscript
NSUser thing;
NSLicenseOwner[] licenseOwners  = thing.GetLicenseOwners();
```

