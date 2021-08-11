---
uid: crmscript_ref_NSPreferenceAgent_SavePreferenceDescription
title: NSPreferenceDescription SavePreferenceDescription(NSPreferenceDescription preferenceDescription);
intellisense: NSPreferenceAgent.SavePreferenceDescription
keywords: NSPreferenceAgent, SavePreferenceDescription
so.topic: reference
---

# NSPreferenceDescription SavePreferenceDescription(NSPreferenceDescription preferenceDescription);
	  
Updates the existing NSPreferenceDescription or creates a new NSPreferenceDescription if the id parameter is 0
	  
**Parameters**:
 - **preferenceDescription** The NSPreferenceDescription to save.

**Returns:** NSPreferenceDescription

```crmscript
NSPreference  agent;
NSPreferenceDescription thing = agent.CreateDefaultPreferenceDescription();
thing = agent.SavePreferenceDescription(thing);
```

