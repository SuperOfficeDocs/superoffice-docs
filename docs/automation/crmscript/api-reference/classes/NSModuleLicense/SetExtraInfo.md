---
uid: crmscript_ref_NSModuleLicense_SetExtraInfo
title: SetExtraInfo(String extraInfo)
intellisense: NSModuleLicense.SetExtraInfo
keywords: NSModuleLicense, GetExtraInfo
so.topic: reference
---

# SetExtraInfo(String extraInfo)

Free field, can be used by the module owner (example: host domain, for eJournal). NOTE: For rows with extraFlags=1 this field contains the list of modules that this plan comprises

**Parameter:** 
 - **extraInfo** String

```crmscript
NSModuleLicense thing;
String extraInfo;
thing.SetExtraInfo(extraInfo);
```

