---
uid: crmscript_ref_NSFormSubmissionEntity_SetStatus
title: SetStatus(FormSubmissionStatus status)
intellisense: NSFormSubmissionEntity.SetStatus
keywords: NSFormSubmissionEntity, GetStatus
so.topic: reference
---

What is the status of this submission

**Parameter:** 
 - **status** FormSubmissionStatus
     - Enum: 0 = Unknown 
     - Enum: 1 = InProgress 
     - Enum: 2 = EmailVerification 
     - Enum: 3 = Submitted 
     - Enum: 4 = Processed 
     - Enum: 5 = Failed 

```crmscript
NSFormSubmissionEntity thing;
FormSubmissionStatus status;
thing.SetStatus(status);
```

