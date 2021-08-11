---
uid: crmscript_ref_NSFormSubmissionEntity_GetStatus
title: Integer GetStatus()
intellisense: NSFormSubmissionEntity.GetStatus
keywords: NSFormSubmissionEntity, GetStatus
so.topic: reference
---

# Integer GetStatus()

What is the status of this submission

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = InProgress 
     - Enum: 2 = EmailVerification 
     - Enum: 3 = Submitted 
     - Enum: 4 = Processed 
     - Enum: 5 = Failed 

```crmscript
NSFormSubmissionEntity thing;
Integer status  = thing.GetStatus();
```

