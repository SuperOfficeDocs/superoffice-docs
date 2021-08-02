---
uid: crmscript_ref_NSWebhook_SetState
title: SetState(Integer state)
intellisense: NSWebhook.SetState
keywords: NSWebhook, GetState
so.topic: reference
---

Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors

**Parameter:** 
 - **state** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Stopped 
     - Enum: 3 = TooManyErrors 

```crmscript
NSWebhook thing;
Integer state;
thing.SetState(state);
```

