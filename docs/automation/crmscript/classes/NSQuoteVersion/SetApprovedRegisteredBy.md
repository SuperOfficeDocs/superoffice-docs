---
uid: crmscript_ref_NSQuoteVersion_SetApprovedRegisteredBy
title: SetApprovedRegisteredBy(Integer approvedRegisteredBy)
intellisense: NSQuoteVersion.SetApprovedRegisteredBy
keywords: NSQuoteVersion, GetApprovedRegisteredBy
so.topic: reference
---

Id of associate who actually entered the approval; might be different from ApprovedBy (f.x. due to telephone consultation/approval)

**Parameter:** 
 - **approvedRegisteredBy** Integer

```crmscript
NSQuoteVersion thing;
Integer approvedRegisteredBy;
thing.SetApprovedRegisteredBy(approvedRegisteredBy);
```

