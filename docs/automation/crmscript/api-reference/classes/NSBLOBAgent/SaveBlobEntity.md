---
uid: crmscript_ref_NSBLOBAgent_SaveBlobEntity
title: NSBlobEntity SaveBlobEntity(NSBlobEntity blobEntity);
intellisense: NSBLOBAgent.SaveBlobEntity
keywords: NSBLOBAgent, SaveBlobEntity
so.topic: reference
---
	  
Updates the existing NSBlobEntity or creates a new NSBlobEntity if the id parameter is 0
	  
**Parameters**:
 - **blobEntity** The NSBlobEntity to save.

**Returns:** New or updated NSBlobEntity

```crmscript
NSBLOB  agent;
NSBlobEntity thing = agent.CreateDefaultBlobEntity();
thing = agent.SaveBlobEntity(thing);
```

