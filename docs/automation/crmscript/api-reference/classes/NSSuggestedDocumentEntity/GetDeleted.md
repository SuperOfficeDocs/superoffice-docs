---
uid: crmscript_ref_NSSuggestedDocumentEntity_GetDeleted
title: Bool GetDeleted()
intellisense: NSSuggestedDocumentEntity.GetDeleted
keywords: NSSuggestedDocumentEntity, GetDeleted
so.topic: reference
---

# Bool GetDeleted()

0 -> record is active 1 -> record is 'deleted' and should not be shown in lists

**Returns:** Bool

```crmscript
NSSuggestedDocumentEntity thing;
Bool deleted  = thing.GetDeleted();
```

