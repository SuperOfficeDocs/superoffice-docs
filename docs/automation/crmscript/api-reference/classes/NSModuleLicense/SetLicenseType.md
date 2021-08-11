---
uid: crmscript_class_nsmodulelicense_setlicensetype
title: SetLicenseType(Integer licenseType)
description: CRMScript method in the NSModuleLicense class that sets the licence type
intellisense: NSModuleLicense.SetLicenseType
keywords: NSModuleLicense, GetLicenseType, SetLicenseType(Integer)
so.topic: reference
---

# SetLicenseType()

The entire system, per database, or per associate.

## Parameter

| Parameter | Type | Description |
|---|---|---|
| licenseType | Integer | The module license type |

### Types

| Enum | Type |
|---|---|
| 0 | Unknown |
| 1 | SiteLicense |
| 2 | SatelliteLicense |
| 3 | UserLicense |

## Examples

```crmscript
NSModuleLicense thing;
Integer licenseType;
thing.SetLicenseType(licenseType);
```
