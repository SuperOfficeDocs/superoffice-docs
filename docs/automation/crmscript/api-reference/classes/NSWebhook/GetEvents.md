---
uid: crmscript_ref_NSWebhook_GetEvents
title: StringArray GetEvents()
intellisense: NSWebhook.GetEvents
keywords: NSWebhook, GetEvents
so.topic: reference
---

Array of event names that trigger this webhook: ['contact.created', 'sale.changed'] 

**Returns:** StringArray


```crmscript
NSWebhook thing;
StringArray events  = thing.GetEvents();
```


