---
uid: crmscript_ref_NSEMailEntity_SetCalMethod
title: SetCalMethod(Integer calMethod)
intellisense: NSEMailEntity.SetCalMethod
keywords: NSEMailEntity, GetCalMethod
so.topic: reference
---

Method stored in the associated iCal appointment. Indicates if the iCal data is a reply, counter proposal etc.

**Parameter:** 
 - **calMethod** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Add 
     - Enum: 2 = Cancel 
     - Enum: 3 = Counter 
     - Enum: 4 = DeclineCounter 
     - Enum: 5 = Publish 
     - Enum: 6 = Refresh 
     - Enum: 7 = Reply 
     - Enum: 8 = Request 

```crmscript
NSEMailEntity thing;
Integer calMethod;
thing.SetCalMethod(calMethod);
```

