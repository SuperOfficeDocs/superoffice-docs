---
uid: crmscript_ref_NSWebhook_GetState
title: Integer GetState()
intellisense: NSWebhook.GetState
keywords: NSWebhook, GetState
so.topic: reference
---

Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Stopped 
     - Enum: 3 = TooManyErrors 

```crmscript
NSWebhook thing;
Integer state  = thing.GetState();
```


