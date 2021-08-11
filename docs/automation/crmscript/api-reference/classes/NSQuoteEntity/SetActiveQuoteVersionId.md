---
uid: crmscript_ref_NSQuoteEntity_SetActiveQuoteVersionId
title: SetActiveQuoteVersionId(Integer activeQuoteVersionId)
intellisense: NSQuoteEntity.SetActiveQuoteVersionId
keywords: NSQuoteEntity, GetActiveQuoteVersionId
so.topic: reference
---

# SetActiveQuoteVersionId(Integer activeQuoteVersionId)

The primary key of the Quote Version that is currently active. (The active version will always be the latest version.)

**Parameter:** 
 - **activeQuoteVersionId** Integer

```crmscript
NSQuoteEntity thing;
Integer activeQuoteVersionId;
thing.SetActiveQuoteVersionId(activeQuoteVersionId);
```

