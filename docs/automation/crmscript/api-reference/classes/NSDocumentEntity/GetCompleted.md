---
uid: crmscript_ref_NSDocumentEntity_GetCompleted
title: Integer GetCompleted()
intellisense: NSDocumentEntity.GetCompleted
keywords: NSDocumentEntity, GetCompleted
so.topic: reference
---

Document Completed state. This is the part of the Status property. 

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 

```crmscript
NSDocumentEntity thing;
Integer completed  = thing.GetCompleted();
```


