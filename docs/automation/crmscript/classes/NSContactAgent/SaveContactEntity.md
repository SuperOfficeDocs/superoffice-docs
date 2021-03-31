---
title: crmscript_ref_NSContactAgent_SaveContactEntity
description: NSContactEntity SaveContactEntity(NSContactEntity contactEntity);
intellisense: NSContactAgent.SaveContactEntity
keywords: NSContactAgent,SaveContactEntity
so.topic: reference
---
	  
Updates the existing NSContactEntity or creates a new NSContactEntity if the id parameter is 0
	  
**Parameters**:
 - **contactEntity** The NSContactEntity to save.

**Returns:** New or updated NSContactEntity

```crmscript
NSContact  agent;
NSContactEntity thing = agent.CreateDefaultContactEntity();
thing = agent.SaveContactEntity(thing);
```

