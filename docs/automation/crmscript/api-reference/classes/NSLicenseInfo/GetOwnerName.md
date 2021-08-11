---
uid: crmscript_ref_NSLicenseInfo_GetOwnerName
title: String GetOwnerName()
intellisense: NSLicenseInfo.GetOwnerName
keywords: NSLicenseInfo, GetOwnerName
so.topic: reference
---

# String GetOwnerName()

The name of the module owner, not visible in GUI but used in the code. OwnerName SUPEROFFICE is reserved and may NEVER be used by partners. This must be in UPPER CASE and only contain A-Z and 0-9. NO EXTENDED CHARACTERS please.

**Returns:** String

```crmscript
NSLicenseInfo thing;
String ownerName  = thing.GetOwnerName();
```

