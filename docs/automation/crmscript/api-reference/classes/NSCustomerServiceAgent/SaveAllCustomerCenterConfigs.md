---
uid: crmscript_ref_NSCustomerServiceAgent_SaveAllCustomerCenterConfigs
title: Void SaveAllCustomerCenterConfigs(NSCustomerCenterConfig[] custConfigs)
intellisense: NSCustomerServiceAgent.SaveAllCustomerCenterConfigs
keywords: NSCustomerServiceAgent, SaveAllCustomerCenterConfigs
so.topic: reference
---

Save an array of NSCustomerCenterConfig entities to the database

**Parameters:**
 - **custConfigs** The NSCustomerCenterConfig entities to be saved. If the id does not exists, a new one will be created. Unknown ids will be skipped

```crmscript
NSCustomerServiceAgent agent;
agent.SaveAllCustomerCenterConfigs(custConfigs);
```

