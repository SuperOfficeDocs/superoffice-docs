---
title: crmscript_ref_NSWebhookAgent_GetAllWebhooks_String_p_0_String_p_1_Integer_p_2
description: NSWebhookAgent.GetAllWebhooks(String p_0, String p_1, Integer p_2)
intellisense: NSWebhookAgent.GetAllWebhooks
keywords: GetAllWebhooks(String,String,Integer)
so.topic: reference
---


Returns all webhooks, according to filter criteria



* **nameFilter:** Only return hooks with this name. Default NULL = no filter
* **eventFilter:** Only return hooks responding to this event name. Default NULL = no filter
* **statusFilter:** Only return hooks with this status. Default Unknown = no filter, returns all.
* **Returns:** Array of all webhooks, filtered according to given criteria.


