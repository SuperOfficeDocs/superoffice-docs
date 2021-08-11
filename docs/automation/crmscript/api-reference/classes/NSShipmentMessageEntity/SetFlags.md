---
uid: crmscript_ref_NSShipmentMessageEntity_SetFlags
title: SetFlags(Integer flags)
intellisense: NSShipmentMessageEntity.SetFlags
keywords: NSShipmentMessageEntity, GetFlags
so.topic: reference
---

# SetFlags(Integer flags)

Identifies if HTML or plain message is included in message.

**Parameter:** 
 - **flags** Integer
     - Enum: 0 = Plain 
     - Enum: 1 = Html 
     - Enum: 2 = SourceView 
     - Enum: 4 = Sms 
     - Enum: 8 = Document 

```crmscript
NSShipmentMessageEntity thing;
Integer flags;
thing.SetFlags(flags);
```

