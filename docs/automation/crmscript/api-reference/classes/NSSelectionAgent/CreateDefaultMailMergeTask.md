---
uid: crmscript_ref_NSSelectionAgent_CreateDefaultMailMergeTask
title: NSMailMergeTask CreateDefaultMailMergeTask()
intellisense: NSSelectionAgent.CreateDefaultMailMergeTask
keywords: NSSelectionAgent, CreateDefaultMailMergeTask
so.topic: reference
---

# NSMailMergeTask CreateDefaultMailMergeTask()
	  
Set default values into a new NSMailMergeTask.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSMailMergeTask

```crmscript
NSSelectionAgent agent;
NSMailMergeTask thing = agent.CreateDefaultMailMergeTask();
thing = agent.SaveMailMergeTask(thing);
```

