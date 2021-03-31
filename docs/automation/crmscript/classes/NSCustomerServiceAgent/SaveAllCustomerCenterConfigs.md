---
title: crmscript_ref_NSCustomerServiceAgent_SaveAllCustomerCenterConfigs
description: Void SaveAllCustomerCenterConfigs(CustomerCenterConfigArray custConfigs)
intellisense: NSCustomerServiceAgent.SaveAllCustomerCenterConfigs
keywords: NSCustomerServiceAgent,SaveAllCustomerCenterConfigs
so.topic: reference
---

Save an array of CustomerCenterConfig entities to the database

**Parameters:**
 - **custConfigs** The CustomerCenterConfig entities to be saved. If the id does not exists, a new one will be created. Unknown ids will be skipped

**Returns:** void

```crmscript
NSCustomerServiceAgent agent;
CustomerCenterConfigArray custConfigs;
Void res = agent.SaveAllCustomerCenterConfigs(custConfigs);
```

