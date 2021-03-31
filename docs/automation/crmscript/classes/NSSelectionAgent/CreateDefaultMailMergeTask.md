---
title: crmscript_ref_NSSelectionAgent_CreateDefaultMailMergeTask
description: NSMailMergeTask CreateDefaultMailMergeTask()
intellisense: NSSelectionAgent.CreateDefaultMailMergeTask
keywords: NSSelectionAgent,CreateDefaultMailMergeTask
so.topic: reference
---
	  
Set default values into a new NSMailMergeTask.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSMailMergeTask with default values.

```crmscript
NSSelectionAgent agent;
NSMailMergeTask thing = agent.CreateDefaultMailMergeTask();
thing = agent.SaveMailMergeTask(thing);
```

