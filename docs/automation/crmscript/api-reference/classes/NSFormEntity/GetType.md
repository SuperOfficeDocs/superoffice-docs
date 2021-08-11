---
uid: crmscript_ref_NSFormEntity_GetType
title: Integer GetType()
intellisense: NSFormEntity.GetType
keywords: NSFormEntity, GetType
so.topic: reference
---

# Integer GetType()

What kind of form is this? Indicates if this is a normal form or a template

**Returns:** Integer

     - Enum: 0 = Normal 
     - Enum: 1 = Template 

```crmscript
NSFormEntity thing;
Integer type  = thing.GetType();
```

