---
uid: crmscript_ref_NSDocumentAgent_SaveDocumentEntity
title: NSDocumentEntity SaveDocumentEntity(NSDocumentEntity documentEntity);
intellisense: NSDocumentAgent.SaveDocumentEntity
keywords: NSDocumentAgent, SaveDocumentEntity
so.topic: reference
---
	  
Updates the existing NSDocumentEntity or creates a new NSDocumentEntity if the id parameter is 0
	  
**Parameters**:
 - **documentEntity** The NSDocumentEntity to save.

**Returns:** NSDocumentEntity

```crmscript
NSDocument  agent;
NSDocumentEntity thing = agent.CreateDefaultDocumentEntity();
thing = agent.SaveDocumentEntity(thing);
```

