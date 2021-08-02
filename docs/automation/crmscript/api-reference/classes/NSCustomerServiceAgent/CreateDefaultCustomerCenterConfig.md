---
uid: crmscript_ref_NSCustomerServiceAgent_CreateDefaultCustomerCenterConfig
title: NSCustomerCenterConfig CreateDefaultCustomerCenterConfig()
intellisense: NSCustomerServiceAgent.CreateDefaultCustomerCenterConfig
keywords: NSCustomerServiceAgent, CreateDefaultCustomerCenterConfig
so.topic: reference
---
	  
Set default values into a new NSCustomerCenterConfig.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSCustomerCenterConfig

```crmscript
NSCustomerServiceAgent agent;
NSCustomerCenterConfig thing = agent.CreateDefaultCustomerCenterConfig();
thing = agent.SaveCustomerCenterConfig(thing);
```

