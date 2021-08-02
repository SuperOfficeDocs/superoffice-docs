---
uid: crmscript_ref_NSLicenseAgent_ChangeSerialNumber
title: NSLicenseResult ChangeSerialNumber(String newCompanyName, String newSerialNumber)
intellisense: NSLicenseAgent.ChangeSerialNumber
keywords: NSLicenseAgent, ChangeSerialNumber
so.topic: reference
---

Change the new serial number for the installation. Requests a new license from SuperLicense, checks if change is authorized.

**Parameters:**
 - **newCompanyName** The new company name
 - **newSerialNumber** New serial number to change to.

**Returns:** NSLicenseResult

```crmscript
NSLicenseAgent agent;
String newCompanyName;
String newSerialNumber;
NSLicenseResult res = agent.ChangeSerialNumber(newCompanyName, newSerialNumber);
```

