---
uid: crmscript_ref_NSHistoryRequest_GetRequestForNewRecord
title: Bool GetRequestForNewRecord()
intellisense: NSHistoryRequest.GetRequestForNewRecord
keywords: NSHistoryRequest, GetRequestForNewRecord
so.topic: reference
---

# Bool GetRequestForNewRecord()

Are we requesting insert rights? If true, then EntityorParentId is taken to mean parent id

**Returns:** Bool

```crmscript
NSHistoryRequest thing;
Bool requestForNewRecord  = thing.GetRequestForNewRecord();
```

