---
uid: crmscript_ref_NSQuoteVersion_GetApprovedRegisteredBy
title: Integer GetApprovedRegisteredBy()
intellisense: NSQuoteVersion.GetApprovedRegisteredBy
keywords: NSQuoteVersion, GetApprovedRegisteredBy
so.topic: reference
---

Id of associate who actually entered the approval; might be different from ApprovedBy (f.x. due to telephone consultation/approval)

**Returns:** Integer


```crmscript
NSQuoteVersion thing;
Integer approvedRegisteredBy  = thing.GetApprovedRegisteredBy();
```


