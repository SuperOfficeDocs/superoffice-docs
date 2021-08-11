---
uid: crmscript_ref_NSLicenseInfo_GetGraceDate
title: DateTime GetGraceDate()
intellisense: NSLicenseInfo.GetGraceDate
keywords: NSLicenseInfo, GetGraceDate
so.topic: reference
---

# DateTime GetGraceDate()

Real expiration date, when the given module actually stops working. Modules that normally update data should switch to read-only mode. Modules that only read anyway, should disable themselves in some other way

**Returns:** DateTime

```crmscript
NSLicenseInfo thing;
DateTime graceDate  = thing.GetGraceDate();
```

