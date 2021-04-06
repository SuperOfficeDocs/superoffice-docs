---
uid: crmscript_ref_NSArchiveAgent_CreateDefaultArchiveListResult
title: NSArchiveListResult CreateDefaultArchiveListResult()
intellisense: NSArchiveAgent.CreateDefaultArchiveListResult
keywords: NSArchiveAgent, CreateDefaultArchiveListResult
so.topic: reference
---
	  
Set default values into a new NSArchiveListResult.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSArchiveListResult with default values.

```crmscript
NSArchiveAgent agent;
NSArchiveListResult thing = agent.CreateDefaultArchiveListResult();
thing = agent.SaveArchiveListResult(thing);
```

