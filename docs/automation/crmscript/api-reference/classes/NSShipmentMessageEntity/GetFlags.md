---
uid: crmscript_ref_NSShipmentMessageEntity_GetFlags
title: Integer GetFlags()
intellisense: NSShipmentMessageEntity.GetFlags
keywords: NSShipmentMessageEntity, GetFlags
so.topic: reference
---

# Integer GetFlags()

Identifies if HTML or plain message is included in message.

**Returns:** Integer

     - Enum: 0 = Plain 
     - Enum: 1 = Html 
     - Enum: 2 = SourceView 
     - Enum: 4 = Sms 
     - Enum: 8 = Document 

```crmscript
NSShipmentMessageEntity thing;
Integer flags  = thing.GetFlags();
```

