---
title: crmscript_ref_NSWebhookAgent_CreateDefaultWebhook
description: NSWebhook CreateDefaultWebhook()
intellisense: NSWebhookAgent.CreateDefaultWebhook
keywords: NSWebhookAgent,CreateDefaultWebhook
so.topic: reference
---
	  
Set default values into a new NSWebhook.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSWebhook with default values.

```crmscript
NSWebhookAgent agent;
NSWebhook thing = agent.CreateDefaultWebhook();
thing = agent.SaveWebhook(thing);
```

