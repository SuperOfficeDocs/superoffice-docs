---
uid: crmscript_ref_NSFormEntity_SetType
title: SetType(FormType type)
intellisense: NSFormEntity.SetType
keywords: NSFormEntity, GetType
so.topic: reference
---

What kind of form is this? Indicates if this is a normal form or a template

**Parameter:** 
 - **type** FormType
     - Enum: 0 = Normal 
     - Enum: 1 = Template 

```crmscript
NSFormEntity thing;
FormType type;
thing.SetType(type);
```

