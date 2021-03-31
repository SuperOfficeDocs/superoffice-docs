---
title: crmscript_ref_NSPreferenceAgent_CreateDefaultPreference
description: NSPreference CreateDefaultPreference()
intellisense: NSPreferenceAgent.CreateDefaultPreference
keywords: NSPreferenceAgent,CreateDefaultPreference
so.topic: reference
---
	  
Set default values into a new NSPreference.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSPreference with default values.

```crmscript
NSPreferenceAgent agent;
NSPreference thing = agent.CreateDefaultPreference();
thing = agent.SavePreference(thing);
```

