---
uid: crmscript_ref_NSVersionInfo_GetVersionId
title: String GetVersionId()
intellisense: NSVersionInfo.GetVersionId
keywords: NSVersionInfo, GetVersionId
so.topic: reference
---

# String GetVersionId()

The document plugin's version id that uniquely identifies one version of a document. If versioning is not supported, this will be blank. When versioning is supported, blank values imply the latest checked-in version.

**Returns:** String

```crmscript
NSVersionInfo thing;
String versionId  = thing.GetVersionId();
```

