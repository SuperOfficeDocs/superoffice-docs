---
uid: crmscript_ref_NSContactActivity_GetAction
title: Integer GetAction()
intellisense: NSContactActivity.GetAction
keywords: NSContactActivity, GetAction
so.topic: reference
---

# Integer GetAction()

The activity that has occured on this contact.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Created 
     - Enum: 2 = Updated 
     - Enum: 4 = NewActivity 
     - Enum: 8 = ActivityCompleted 
     - Enum: 16 = PersonAdded 
     - Enum: 32 = PersonUpdated 
     - Enum: 64 = DocumentAdded 
     - Enum: 127 = All 

```crmscript
NSContactActivity thing;
Integer action  = thing.GetAction();
```

