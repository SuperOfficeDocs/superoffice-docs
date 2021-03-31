---
title: crmscript_ref_NSEMailAgent_CreateDefaultEMailConnectionInfo
description: NSEMailConnectionInfo CreateDefaultEMailConnectionInfo()
intellisense: NSEMailAgent.CreateDefaultEMailConnectionInfo
keywords: NSEMailAgent,CreateDefaultEMailConnectionInfo
so.topic: reference
---
	  
Set default values into a new NSEMailConnectionInfo.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSEMailConnectionInfo with default values.

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo thing = agent.CreateDefaultEMailConnectionInfo();
thing = agent.SaveEMailConnectionInfo(thing);
```

