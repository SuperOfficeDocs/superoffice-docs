---
uid: crmscript_ref_NSDocumentEntity_GetType
title: Integer GetType()
intellisense: NSDocumentEntity.GetType
keywords: NSDocumentEntity, GetType
so.topic: reference
---

# Integer GetType()

Is this a normal document or a mail-merge or report?

**Returns:** Integer

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
Integer type  = thing.GetType();
```

