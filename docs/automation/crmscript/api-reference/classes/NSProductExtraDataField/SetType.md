---
uid: crmscript_ref_NSProductExtraDataField_SetType
title: SetType(Integer type)
intellisense: NSProductExtraDataField.SetType
keywords: NSProductExtraDataField, GetType
so.topic: reference
---

# SetType(Integer type)

String, url, image. How the value should be interpreted.

**Parameter:** 
 - **type** Integer
     - Enum: 0 = String 
     - Enum: 1 = Url 
     - Enum: 2 = Image 

```crmscript
NSProductExtraDataField thing;
Integer type;
thing.SetType(type);
```

