---
uid: crmscript_ref_NSAudienceAgent_SaveAudienceLayoutEntity
title: NSAudienceLayoutEntity SaveAudienceLayoutEntity(NSAudienceLayoutEntity audienceLayoutEntity);
intellisense: NSAudienceAgent.SaveAudienceLayoutEntity
keywords: NSAudienceAgent, SaveAudienceLayoutEntity
so.topic: reference
---
	  
Updates the existing NSAudienceLayoutEntity or creates a new NSAudienceLayoutEntity if the id parameter is 0
	  
**Parameters**:
 - **audienceLayoutEntity** The NSAudienceLayoutEntity to save.

**Returns:** New or updated NSAudienceLayoutEntity

```crmscript
NSAudience  agent;
NSAudienceLayoutEntity thing = agent.CreateDefaultAudienceLayoutEntity();
thing = agent.SaveAudienceLayoutEntity(thing);
```

