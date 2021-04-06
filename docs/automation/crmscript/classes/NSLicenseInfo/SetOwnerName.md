---
uid: crmscript_ref_NSLicenseInfo_SetOwnerName
title: SetOwnerName(String ownerName)
intellisense: NSLicenseInfo.SetOwnerName
keywords: NSLicenseInfo, GetOwnerName
so.topic: reference
---

The name of the module owner, not visible in GUI but used in the code. OwnerName SUPEROFFICE is reserved and may NEVER be used by partners. This must be in UPPER CASE and only contain A-Z and 0-9. NO EXTENDED CHARACTERS please.

**Parameter:** 
 - **ownerName** String

```crmscript
NSLicenseInfo thing;
String ownerName;
thing.SetOwnerName(ownerName);
```

