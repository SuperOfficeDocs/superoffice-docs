---
uid: crmscript_ref_NSBLOBAgent_CreateDefaultBlobEntity
title: NSBlobEntity CreateDefaultBlobEntity()
intellisense: NSBLOBAgent.CreateDefaultBlobEntity
keywords: NSBLOBAgent, CreateDefaultBlobEntity
so.topic: reference
---

# NSBlobEntity CreateDefaultBlobEntity()
	  
Set default values into a new NSBlobEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSBlobEntity with default values.

```crmscript
NSBLOBAgent agent;
NSBlobEntity thing = agent.CreateDefaultBlobEntity();
thing = agent.SaveBlobEntity(thing);
```

