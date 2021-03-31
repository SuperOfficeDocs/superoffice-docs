---
title: crmscript_ref_NSEMailAgent_CreateDefaultEMailFolder
description: NSEMailFolder CreateDefaultEMailFolder()
intellisense: NSEMailAgent.CreateDefaultEMailFolder
keywords: NSEMailAgent,CreateDefaultEMailFolder
so.topic: reference
---
	  
Set default values into a new NSEMailFolder.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSEMailFolder with default values.

```crmscript
NSEMailAgent agent;
NSEMailFolder thing = agent.CreateDefaultEMailFolder();
thing = agent.SaveEMailFolder(thing);
```

