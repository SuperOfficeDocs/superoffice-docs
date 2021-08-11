---
uid: crmscript_ref_NSWebhookAgent_GetAllWebhooks
title: NSWebhook[] GetAllWebhooks(String nameFilter, String eventFilter, Integer statusFilter)
intellisense: NSWebhookAgent.GetAllWebhooks
keywords: NSWebhookAgent, GetAllWebhooks
so.topic: reference
---

# NSWebhook[] GetAllWebhooks(String nameFilter, String eventFilter, Integer statusFilter)

Returns all webhooks, according to filter criteria

**Parameters:**
 - **nameFilter** Only return hooks with this name. Default NULL = no filter
 - **eventFilter** Only return hooks responding to this event name. Default NULL = no filter
 - **statusFilter** Only return hooks with this status. Default Unknown = no filter, returns all.
     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Stopped 
     - Enum: 3 = TooManyErrors 

**Returns:** NSWebhook[]

```crmscript
NSWebhookAgent agent;
String nameFilter;
String eventFilter;
Integer statusFilter;
NSWebhook[] res = agent.GetAllWebhooks(nameFilter, eventFilter, statusFilter);
```

