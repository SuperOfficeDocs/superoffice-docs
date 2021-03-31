---
title: crmscript_ref_NSPersonAgent_SavePersonEntity
description: NSPersonEntity SavePersonEntity(NSPersonEntity personEntity);
intellisense: NSPersonAgent.SavePersonEntity
keywords: NSPersonAgent,SavePersonEntity
so.topic: reference
---
	  
Updates the existing NSPersonEntity or creates a new NSPersonEntity if the id parameter is 0
	  
**Parameters**:
 - **personEntity** The NSPersonEntity to save.

**Returns:** New or updated NSPersonEntity

```crmscript
NSPerson  agent;
NSPersonEntity thing = agent.CreateDefaultPersonEntity();
thing = agent.SavePersonEntity(thing);
```

