---
title: crmscript_ref_NSWebhookAgent_SignalEvent_String_p_0_Integer_p_1_NSStringObjectDictionary_p_2
description: NSWebhookAgent.SignalEvent(String p_0, Integer p_1, NSStringObjectDictionary p_2)
intellisense: NSWebhookAgent.SignalEvent
keywords: SignalEvent(String,Integer,NSStringObjectDictionary)
so.topic: reference
---


Signal webhooks that an event has occurred. All webhooks listening for the event will be notified.



* **eventName:** Name of event to fire. 'entity.verb' For example: 'window.closed', 'button.clicked'.
* **primaryKey:** (Optional) Id of entity that is firing event. Can be 0 if not used.
* **data:** Event data. Not all the data values may be posted to the webhook, depending in webhook type: { 'windowName': 'foo', 'widgets': 123 }
* **Returns:** This method has no return value


