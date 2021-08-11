---
uid: crmscript_ref_NSCheckLicenseStatusResult_SetLicenseStatus
title: SetLicenseStatus(Integer licenseStatus)
intellisense: NSCheckLicenseStatusResult.SetLicenseStatus
keywords: NSCheckLicenseStatusResult, GetLicenseStatus
so.topic: reference
---

# SetLicenseStatus(Integer licenseStatus)

Result of CheckLicenseStatus 

**Parameter:** 
 - **licenseStatus** Integer
     - Enum: 0 = Ok 
     - Enum: 1 = NewLicenseAvailable 
     - Enum: 2 = NewCompanyNameAvailable 
     - Enum: 3 = NewSerialAvailable 
     - Enum: 4 = UseCustomMessage 
     - Enum: 5 = UseCustomMessageAndUrl 
     - Enum: 100 = ProblemWithLicense 
     - Enum: 5000 = UnknownError 

```crmscript
NSCheckLicenseStatusResult thing;
Integer licenseStatus;
thing.SetLicenseStatus(licenseStatus);
```

