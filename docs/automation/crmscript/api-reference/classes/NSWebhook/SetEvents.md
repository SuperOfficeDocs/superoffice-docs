---
uid: crmscript_ref_NSWebhook_SetEvents
title: SetEvents(String[] events)
intellisense: NSWebhook.SetEvents
keywords: NSWebhook, GetEvents
so.topic: reference
---

# SetEvents(String[] events)

Array of event names that trigger this webhook: ['contact.created', 'sale.changed'] 

**Parameter:** 
 - **events** String[]

```crmscript
NSWebhook thing;
String[] events;
thing.SetEvents(events);
```

