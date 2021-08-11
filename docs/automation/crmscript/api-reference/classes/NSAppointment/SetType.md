---
uid: crmscript_ref_NSAppointment_SetType
title: SetType(Integer type)
intellisense: NSAppointment.SetType
keywords: NSAppointment, GetType
so.topic: reference
---

# SetType(Integer type)

The different types of appointment, if the appointment is supposed to be shown in the diary or checklist, or if it's a document. See the different types of appointments in the database manual.

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
NSAppointment thing;
Integer type;
thing.SetType(type);
```

