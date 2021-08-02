---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailAccount
title: NSEMailAccount CreateDefaultEMailAccount()
intellisense: NSEMailAgent.CreateDefaultEMailAccount
keywords: NSEMailAgent, CreateDefaultEMailAccount
so.topic: reference
---
	  
Set default values into a new NSEMailAccount.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSEMailAccount

```crmscript
NSEMailAgent agent;
NSEMailAccount thing = agent.CreateDefaultEMailAccount();
thing = agent.SaveEMailAccount(thing);
```

