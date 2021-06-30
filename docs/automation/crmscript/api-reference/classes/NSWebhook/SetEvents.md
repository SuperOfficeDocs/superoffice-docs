---
uid: crmscript_ref_NSWebhook_SetEvents
title: SetEvents(String[] events)
intellisense: NSWebhook.SetEvents
keywords: NSWebhook, GetEvents
so.topic: reference
---

Array of event names that trigger this webhook: ['contact.created', 'sale.changed'] 

**Parameter:** 
 - **events** StringArray

```crmscript
NSWebhook thing;
String[] events;
thing.SetEvents(events);
```

