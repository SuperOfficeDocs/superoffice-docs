---
uid: crmscript_ref_NSExtAppEntity_SetExecuteOnEvent
title: SetExecuteOnEvent(NSExecuteOnEvent executeOnEvent)
intellisense: NSExtAppEntity.SetExecuteOnEvent
keywords: NSExtAppEntity, GetExecuteOnEvent
so.topic: reference
---

# SetExecuteOnEvent(NSExecuteOnEvent executeOnEvent)

Events that cause automatic execution of this app

**Parameter:** 
 - **executeOnEvent** NSExecuteOnEvent
     - Enum: 0 = Never 
     - Enum: 1 = Logon 
     - Enum: 2 = Logoff 
     - Enum: 3 = LocalUpdate 
     - Enum: 16384 = Wait 

```crmscript
NSExtAppEntity thing;
NSExecuteOnEvent executeOnEvent;
thing.SetExecuteOnEvent(executeOnEvent);
```

