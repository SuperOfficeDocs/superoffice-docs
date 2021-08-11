---
uid: crmscript_ref_NSDocumentTemplate_GetDirection
title: NSDocTmplDirection GetDirection()
intellisense: NSDocumentTemplate.GetDirection
keywords: NSDocumentTemplate, GetDirection
so.topic: reference
---

# NSDocTmplDirection GetDirection()

1 = incoming, 2 = outgoing, see EAppntDirection

**Returns:** NSDocTmplDirection

     - Enum: 0 = Unknown 
     - Enum: 1 = Incoming 
     - Enum: 2 = Outgoing 
     - Enum: 3 = SaintAll 

```crmscript
NSDocumentTemplate thing;
NSDocTmplDirection direction  = thing.GetDirection();
```

