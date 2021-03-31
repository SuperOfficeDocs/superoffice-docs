---
uid: crmscript_ref_NSWebhookAgent_SaveWebhook
title: NSWebhook SaveWebhook(NSWebhook webhook);
intellisense: NSWebhookAgent.SaveWebhook
keywords: NSWebhookAgent, SaveWebhook
so.topic: reference
---
	  
Updates the existing NSWebhook or creates a new NSWebhook if the id parameter is 0
	  
**Parameters**:
 - **webhook** The NSWebhook to save.

**Returns:** New or updated NSWebhook

```crmscript
NSWebhook  agent;
NSWebhook thing = agent.CreateDefaultWebhook();
thing = agent.SaveWebhook(thing);
```

