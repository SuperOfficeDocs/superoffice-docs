---
title: crmscript_ref_NSEMailAgent_CreateDefaultEMailAccount
description: NSEMailAccount CreateDefaultEMailAccount()
intellisense: NSEMailAgent.CreateDefaultEMailAccount
keywords: NSEMailAgent,CreateDefaultEMailAccount
so.topic: reference
---
	  
Set default values into a new NSEMailAccount.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSEMailAccount with default values.

```crmscript
NSEMailAgent agent;
NSEMailAccount thing = agent.CreateDefaultEMailAccount();
thing = agent.SaveEMailAccount(thing);
```

