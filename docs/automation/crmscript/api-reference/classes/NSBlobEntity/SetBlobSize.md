---
uid: crmscript_ref_NSBlobEntity_SetBlobSize
title: SetBlobSize(Integer blobSize)
intellisense: NSBlobEntity.SetBlobSize
keywords: NSBlobEntity, GetBlobSize
so.topic: reference
---

# SetBlobSize(Integer blobSize)

The length, in bytes, of the binary data AS STORED after any encryption and/or zipping. Important to get right, since some databases will not tell us just based on the blob itself!

**Parameter:** 
 - **blobSize** Integer

```crmscript
NSBlobEntity thing;
Integer blobSize;
thing.SetBlobSize(blobSize);
```

