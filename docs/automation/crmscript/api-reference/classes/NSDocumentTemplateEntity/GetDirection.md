---
uid: crmscript_ref_NSDocumentTemplateEntity_GetDirection
title: NSDocTmplDirection GetDirection()
intellisense: NSDocumentTemplateEntity.GetDirection
keywords: NSDocumentTemplateEntity, GetDirection
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
NSDocumentTemplateEntity thing;
NSDocTmplDirection direction  = thing.GetDirection();
```

