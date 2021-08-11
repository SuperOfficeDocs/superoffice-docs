---
uid: crmscript_ref_NSWebhookAgent_TestWebhook
title: NSWebhookResult TestWebhook(NSWebhook webhook)
intellisense: NSWebhookAgent.TestWebhook
keywords: NSWebhookAgent, TestWebhook
so.topic: reference
---

# NSWebhookResult TestWebhook(NSWebhook webhook)

Pings a webhook with a 'test' event, returns SUCCESS(true) or FAILURE(false) + the response from the webhook target.

**Parameters:**
 - **webhook** NSWebhook definition to ping. Must contain a valid TargetUrl.

**Returns:** NSWebhookResult

```crmscript
NSWebhookAgent agent;
NSWebhook webhook;
NSWebhookResult res = agent.TestWebhook(webhook);
```

