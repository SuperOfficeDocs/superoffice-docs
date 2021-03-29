---
title: crmscript_ref_NSWebhookAgent_TestWebhook_NSWebhook_p_0
description: NSWebhookAgent.TestWebhook(NSWebhook p_0)
intellisense: NSWebhookAgent.TestWebhook
keywords: TestWebhook(NSWebhook)
so.topic: reference
---


Pings a webhook with a 'test' event, returns `SUCCESS(true)` or `FAILURE(false)` + the response from the webhook target.



* **webhook:** Webhook definition to ping. Must contain a valid TargetUrl.
* **Returns:** Result of calling webhook. Sucess=true/false + Error message


