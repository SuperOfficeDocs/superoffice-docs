---
uid: crmscript_ref_NSVersionInfo_SetVersionId
title: SetVersionId(String versionId)
intellisense: NSVersionInfo.SetVersionId
keywords: NSVersionInfo, GetVersionId
so.topic: reference
---

The document plugin's version id that uniquely identifies one version of a document. If versioning is not supported, this will be blank. When versioning is supported, blank values imply the latest checked-in version.

**Parameter:** 
 - **versionId** String

```crmscript
NSVersionInfo thing;
String versionId;
thing.SetVersionId(versionId);
```

