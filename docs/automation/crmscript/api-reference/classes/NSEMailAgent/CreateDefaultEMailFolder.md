---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailFolder
title: NSEMailFolder CreateDefaultEMailFolder()
intellisense: NSEMailAgent.CreateDefaultEMailFolder
keywords: NSEMailAgent, CreateDefaultEMailFolder
so.topic: reference
---
	  
Set default values into a new NSEMailFolder.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSEMailFolder

```crmscript
NSEMailAgent agent;
NSEMailFolder thing = agent.CreateDefaultEMailFolder();
thing = agent.SaveEMailFolder(thing);
```

