---
title: crmscript_ref_NSSelectionAgent_CreateDefaultMailMergeSettings
description: NSMailMergeSettings CreateDefaultMailMergeSettings()
intellisense: NSSelectionAgent.CreateDefaultMailMergeSettings
keywords: NSSelectionAgent,CreateDefaultMailMergeSettings
so.topic: reference
---
	  
Set default values into a new NSMailMergeSettings.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSMailMergeSettings with default values.

```crmscript
NSSelectionAgent agent;
NSMailMergeSettings thing = agent.CreateDefaultMailMergeSettings();
thing = agent.SaveMailMergeSettings(thing);
```

