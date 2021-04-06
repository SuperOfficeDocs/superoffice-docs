---
uid: crmscript_ref_NSReturnInfo_GetVersionId
title: String GetVersionId()
intellisense: NSReturnInfo.GetVersionId
keywords: NSReturnInfo, GetVersionId
so.topic: reference
---

The document plugin's version id that uniquely identifies one version of a document. If versioning is not supported, this will be blank. When versioning is supported, blank values imply the latest checked-in version.

**Returns:** String


```crmscript
NSReturnInfo thing;
String versionId  = thing.GetVersionId();
```


