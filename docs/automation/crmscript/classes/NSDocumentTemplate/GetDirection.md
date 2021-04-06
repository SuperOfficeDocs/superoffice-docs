---
uid: crmscript_ref_NSDocumentTemplate_GetDirection
title: DocTmplDirection GetDirection()
intellisense: NSDocumentTemplate.GetDirection
keywords: NSDocumentTemplate, GetDirection
so.topic: reference
---

1 = incoming, 2 = outgoing, see EAppntDirection

**Returns:** DocTmplDirection

     - Enum: 0 = Unknown 
     - Enum: 1 = Incoming 
     - Enum: 2 = Outgoing 
     - Enum: 3 = SaintAll 

```crmscript
NSDocumentTemplate thing;
DocTmplDirection direction  = thing.GetDirection();
```


