---
title: crmscript_ref_NSLicenseAgent_ChangeSerialNumber
description: LicenseResult ChangeSerialNumber(String newCompanyName, String newSerialNumber)
intellisense: NSLicenseAgent.ChangeSerialNumber
keywords: NSLicenseAgent,ChangeSerialNumber
so.topic: reference
---

Change the new serial number for the installation. Requests a new license from SuperLicense, checks if change is authorized.

**Parameters:**
 - **newCompanyName** The new company name
 - **newSerialNumber** New serial number to change to.

**Returns:** License after serial number/name change

```crmscript
NSLicenseAgent agent;
String newCompanyName;
String newSerialNumber;
LicenseResult res = agent.ChangeSerialNumber(newCompanyName, newSerialNumber);
```

