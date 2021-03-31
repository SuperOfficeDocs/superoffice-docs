---
title: crmscript_ref_NSSaintAgent_SaveSaintConfiguration
description: NSSaintConfiguration SaveSaintConfiguration(NSSaintConfiguration saintConfiguration);
intellisense: NSSaintAgent.SaveSaintConfiguration
keywords: NSSaintAgent,SaveSaintConfiguration
so.topic: reference
---
	  
Updates the existing NSSaintConfiguration or creates a new NSSaintConfiguration if the id parameter is 0
	  
**Parameters**:
 - **saintConfiguration** The NSSaintConfiguration to save.

**Returns:** New or updated NSSaintConfiguration

```crmscript
NSSaint  agent;
NSSaintConfiguration thing = agent.CreateDefaultSaintConfiguration();
thing = agent.SaveSaintConfiguration(thing);
```

