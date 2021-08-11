---
uid: crmscript_ref_NSAudienceAgent_CreateDefaultAudienceLayoutEntity
title: NSAudienceLayoutEntity CreateDefaultAudienceLayoutEntity()
intellisense: NSAudienceAgent.CreateDefaultAudienceLayoutEntity
keywords: NSAudienceAgent, CreateDefaultAudienceLayoutEntity
so.topic: reference
---

# NSAudienceLayoutEntity CreateDefaultAudienceLayoutEntity()
	  
Set default values into a new NSAudienceLayoutEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSAudienceLayoutEntity with default values.

```crmscript
NSAudienceAgent agent;
NSAudienceLayoutEntity thing = agent.CreateDefaultAudienceLayoutEntity();
thing = agent.SaveAudienceLayoutEntity(thing);
```

