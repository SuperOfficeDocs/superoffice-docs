---
uid: crmscript_ref_NSSaintAgent_SaveSaintConfiguration
title: NSSaintConfiguration SaveSaintConfiguration(NSSaintConfiguration saintConfiguration);
intellisense: NSSaintAgent.SaveSaintConfiguration
keywords: NSSaintAgent, SaveSaintConfiguration
so.topic: reference
---

# NSSaintConfiguration SaveSaintConfiguration(NSSaintConfiguration saintConfiguration);
	  
Updates the existing NSSaintConfiguration or creates a new NSSaintConfiguration if the id parameter is 0
	  
**Parameters**:
 - **saintConfiguration** The NSSaintConfiguration to save.

**Returns:** NSSaintConfiguration

```crmscript
NSSaint  agent;
NSSaintConfiguration thing = agent.CreateDefaultSaintConfiguration();
thing = agent.SaveSaintConfiguration(thing);
```

