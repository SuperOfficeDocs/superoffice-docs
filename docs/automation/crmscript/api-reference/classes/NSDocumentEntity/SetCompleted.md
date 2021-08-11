---
uid: crmscript_ref_NSDocumentEntity_SetCompleted
title: SetCompleted(Integer completed)
intellisense: NSDocumentEntity.SetCompleted
keywords: NSDocumentEntity, GetCompleted
so.topic: reference
---

# SetCompleted(Integer completed)

Document Completed state. This is the part of the Status property. 

**Parameter:** 
 - **completed** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 

```crmscript
NSDocumentEntity thing;
Integer completed;
thing.SetCompleted(completed);
```

