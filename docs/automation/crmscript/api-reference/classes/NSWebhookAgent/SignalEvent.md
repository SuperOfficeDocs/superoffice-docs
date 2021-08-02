---
uid: crmscript_ref_NSWebhookAgent_SignalEvent
title: Void SignalEvent(String eventName, Integer primaryKey, StringObjectDictionary data)
intellisense: NSWebhookAgent.SignalEvent
keywords: NSWebhookAgent, SignalEvent
so.topic: reference
---

Signal webhooks that an event has occurred. All webhooks listening for the event will be notified.

**Parameters:**
 - **eventName** Name of event to fire. 'entity.verb' For example: 'window.closed', 'button.clicked'.
 - **primaryKey** (Optional) Id of entity that is firing event. Can be 0 if not used.
 - **data** Event data. Not all the data values may be posted to the webhook, depending in webhook type: { 'windowName': 'foo', 'widgets': 123 }

**Returns:** This method has no return value

```crmscript
NSWebhookAgent agent;
String eventName;
Integer primaryKey;
StringObjectDictionary data;
agent.SignalEvent(eventName, primaryKey, data);
```

