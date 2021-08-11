---
uid: crmscript_ref_NSImportLine_SetType
title: SetType(Integer type)
intellisense: NSImportLine.SetType
keywords: NSImportLine, GetType
so.topic: reference
---

# SetType(Integer type)

Which entity type will be created? This is a read-only property

**Parameter:** 
 - **type** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Person 
     - Enum: 2 = Contact 
     - Enum: 4 = Product 

```crmscript
NSImportLine thing;
Integer type;
thing.SetType(type);
```

