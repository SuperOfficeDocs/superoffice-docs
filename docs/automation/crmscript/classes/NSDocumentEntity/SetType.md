---
uid: crmscript_ref_NSDocumentEntity_SetType
title: SetType(Integer type)
intellisense: NSDocumentEntity.SetType
keywords: NSDocumentEntity, GetType
so.topic: reference
---

Is this a normal document or a mail-merge or report?

**Parameter:** 
 - **type** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = inDiary 
     - Enum: 2 = inChecklist 
     - Enum: 3 = Note 
     - Enum: 4 = Document 
     - Enum: 5 = SavedReport 
     - Enum: 6 = BookingForDiary 
     - Enum: 7 = BookingForChecklist 
     - Enum: 8 = MergeDraft 
     - Enum: 9 = MergeFinal 

```crmscript
NSDocumentEntity thing;
Integer type;
thing.SetType(type);
```

