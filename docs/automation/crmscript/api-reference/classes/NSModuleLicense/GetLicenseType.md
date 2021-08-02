---
uid: crmscript_ref_NSModuleLicense_GetLicenseType
title: Integer GetLicenseType()
intellisense: NSModuleLicense.GetLicenseType
keywords: NSModuleLicense, GetLicenseType
so.topic: reference
---

Entire system, per database, or per associate

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = SiteLicense 
     - Enum: 2 = SatelliteLicense 
     - Enum: 3 = UserLicense 

```crmscript
NSModuleLicense thing;
Integer licenseType  = thing.GetLicenseType();
```


