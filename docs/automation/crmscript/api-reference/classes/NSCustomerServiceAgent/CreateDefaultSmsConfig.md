---
uid: crmscript_ref_NSCustomerServiceAgent_CreateDefaultSmsConfig
title: NSSmsConfig CreateDefaultSmsConfig()
intellisense: NSCustomerServiceAgent.CreateDefaultSmsConfig
keywords: NSCustomerServiceAgent, CreateDefaultSmsConfig
so.topic: reference
---
	  
Set default values into a new NSSmsConfig.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSSmsConfig

```crmscript
NSCustomerServiceAgent agent;
NSSmsConfig thing = agent.CreateDefaultSmsConfig();
thing = agent.SaveSmsConfig(thing);
```

