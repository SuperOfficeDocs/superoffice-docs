---
title: crmscript_ref_NSPreferenceAgent_CreateDefaultPreferenceDescriptionLine
description: NSPreferenceDescriptionLine CreateDefaultPreferenceDescriptionLine()
intellisense: NSPreferenceAgent.CreateDefaultPreferenceDescriptionLine
keywords: NSPreferenceAgent,CreateDefaultPreferenceDescriptionLine
so.topic: reference
---
	  
Set default values into a new NSPreferenceDescriptionLine.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSPreferenceDescriptionLine with default values.

```crmscript
NSPreferenceAgent agent;
NSPreferenceDescriptionLine thing = agent.CreateDefaultPreferenceDescriptionLine();
thing = agent.SavePreferenceDescriptionLine(thing);
```

