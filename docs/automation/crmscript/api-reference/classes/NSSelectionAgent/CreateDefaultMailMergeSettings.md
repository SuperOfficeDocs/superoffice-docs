---
uid: crmscript_ref_NSSelectionAgent_CreateDefaultMailMergeSettings
title: NSMailMergeSettings CreateDefaultMailMergeSettings()
intellisense: NSSelectionAgent.CreateDefaultMailMergeSettings
keywords: NSSelectionAgent, CreateDefaultMailMergeSettings
so.topic: reference
---

# NSMailMergeSettings CreateDefaultMailMergeSettings()
	  
Set default values into a new NSMailMergeSettings.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSMailMergeSettings

```crmscript
NSSelectionAgent agent;
NSMailMergeSettings thing = agent.CreateDefaultMailMergeSettings();
thing = agent.SaveMailMergeSettings(thing);
```

