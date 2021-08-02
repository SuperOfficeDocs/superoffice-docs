---
uid: crmscript_ref_NSSaintAgent_CreateDefaultSaintConfiguration
title: NSSaintConfiguration CreateDefaultSaintConfiguration()
intellisense: NSSaintAgent.CreateDefaultSaintConfiguration
keywords: NSSaintAgent, CreateDefaultSaintConfiguration
so.topic: reference
---
	  
Set default values into a new NSSaintConfiguration.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSSaintConfiguration

```crmscript
NSSaintAgent agent;
NSSaintConfiguration thing = agent.CreateDefaultSaintConfiguration();
thing = agent.SaveSaintConfiguration(thing);
```

