---
uid: crmscript_ref_NSCustomerServiceAgent_SaveCustomerCenterConfig
title: NSCustomerCenterConfig SaveCustomerCenterConfig(NSCustomerCenterConfig customerCenterConfig);
intellisense: NSCustomerServiceAgent.SaveCustomerCenterConfig
keywords: NSCustomerServiceAgent, SaveCustomerCenterConfig
so.topic: reference
---
	  
Updates the existing NSCustomerCenterConfig or creates a new NSCustomerCenterConfig if the id parameter is 0
	  
**Parameters**:
 - **customerCenterConfig** The NSCustomerCenterConfig to save.

**Returns:** NSCustomerCenterConfig

```crmscript
NSCustomerService  agent;
NSCustomerCenterConfig thing = agent.CreateDefaultCustomerCenterConfig();
thing = agent.SaveCustomerCenterConfig(thing);
```

