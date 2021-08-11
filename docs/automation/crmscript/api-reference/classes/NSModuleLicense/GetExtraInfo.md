---
uid: crmscript_ref_NSModuleLicense_GetExtraInfo
title: String GetExtraInfo()
intellisense: NSModuleLicense.GetExtraInfo
keywords: NSModuleLicense, GetExtraInfo
so.topic: reference
---

# String GetExtraInfo()

Free field, can be used by the module owner (example: host domain, for eJournal). NOTE: For rows with extraFlags=1 this field contains the list of modules that this plan comprises

**Returns:** String

```crmscript
NSModuleLicense thing;
String extraInfo  = thing.GetExtraInfo();
```

