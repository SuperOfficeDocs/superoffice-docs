---
title: crmscript_ref_NSWebhookAgent_TestWebhook
description: WebhookResult TestWebhook(Webhook webhook)
intellisense: NSWebhookAgent.TestWebhook
keywords: NSWebhookAgent,TestWebhook
so.topic: reference
---

Pings a webhook with a 'test' event, returns SUCCESS(true) or FAILURE(false) + the response from the webhook target.

**Parameters:**
 - **webhook** Webhook definition to ping. Must contain a valid TargetUrl.

**Returns:** Result of calling webhook. Sucess=true/false + Error message

```crmscript
NSWebhookAgent agent;
Webhook webhook;
WebhookResult res = agent.TestWebhook(webhook);
```

