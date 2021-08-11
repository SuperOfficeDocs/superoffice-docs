---
uid: crmscript_ref_NSUserDefinedFieldInfo_SetType
title: SetType(Integer type)
intellisense: NSUserDefinedFieldInfo.SetType
keywords: NSUserDefinedFieldInfo, GetType
so.topic: reference
---

# SetType(Integer type)

ID of owning table (contact, person, project) - this is not the actual tableNumber, rather it's an enum

**Parameter:** 
 - **type** Integer
     - Enum: 0 = Invalid 
     - Enum: 7 = Contact 
     - Enum: 8 = Person 
     - Enum: 9 = Project 
     - Enum: 10 = Sale 
     - Enum: 11 = Temp 
     - Enum: 12 = Appointment 
     - Enum: 13 = Document 
     - Enum: 14 = None 

```crmscript
NSUserDefinedFieldInfo thing;
Integer type;
thing.SetType(type);
```

