---
uid: crmscript_ref_NSPreferenceAgent_CreateDefaultPreferenceDescription
title: NSPreferenceDescription CreateDefaultPreferenceDescription()
intellisense: NSPreferenceAgent.CreateDefaultPreferenceDescription
keywords: NSPreferenceAgent, CreateDefaultPreferenceDescription
so.topic: reference
---
	  
Set default values into a new NSPreferenceDescription.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSPreferenceDescription with default values.

```crmscript
NSPreferenceAgent agent;
NSPreferenceDescription thing = agent.CreateDefaultPreferenceDescription();
thing = agent.SavePreferenceDescription(thing);
```

