---
uid: crmscript_ref_NSExtAppEntity_GetExecuteOnEvent
title: NSExecuteOnEvent GetExecuteOnEvent()
intellisense: NSExtAppEntity.GetExecuteOnEvent
keywords: NSExtAppEntity, GetExecuteOnEvent
so.topic: reference
---

Events that cause automatic execution of this app

**Returns:** NSExecuteOnEvent

     - Enum: 0 = Never 
     - Enum: 1 = Logon 
     - Enum: 2 = Logoff 
     - Enum: 3 = LocalUpdate 
     - Enum: 16384 = Wait 

```crmscript
NSExtAppEntity thing;
NSExecuteOnEvent executeOnEvent  = thing.GetExecuteOnEvent();
```


