---
uid: crmscript_ref_NSFormEntity_SetType
title: SetType(Integer type)
intellisense: NSFormEntity.SetType
keywords: NSFormEntity, GetType
so.topic: reference
---

What kind of form is this? Indicates if this is a normal form or a template

**Parameter:** 
 - **type** Integer
     - Enum: 0 = Normal 
     - Enum: 1 = Template 

```crmscript
NSFormEntity thing;
Integer type = 0;
thing.SetType(type);
```

