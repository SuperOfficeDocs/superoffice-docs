---
uid: crmscript_ref_NSImportLine_GetType
title: Integer GetType()
intellisense: NSImportLine.GetType
keywords: NSImportLine, GetType
so.topic: reference
---

Which entity type will be created? This is a read-only property

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Person 
     - Enum: 2 = Contact 
     - Enum: 4 = Product 

```crmscript
NSImportLine thing;
Integer type  = thing.GetType();
```


