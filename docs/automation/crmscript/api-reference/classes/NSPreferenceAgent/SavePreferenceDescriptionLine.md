---
uid: crmscript_ref_NSPreferenceAgent_SavePreferenceDescriptionLine
title: NSPreferenceDescriptionLine SavePreferenceDescriptionLine(NSPreferenceDescriptionLine preferenceDescriptionLine);
intellisense: NSPreferenceAgent.SavePreferenceDescriptionLine
keywords: NSPreferenceAgent, SavePreferenceDescriptionLine
so.topic: reference
---
	  
Updates the existing NSPreferenceDescriptionLine or creates a new NSPreferenceDescriptionLine if the id parameter is 0
	  
**Parameters**:
 - **preferenceDescriptionLine** The NSPreferenceDescriptionLine to save.

**Returns:** NSPreferenceDescriptionLine

```crmscript
NSPreference  agent;
NSPreferenceDescriptionLine thing = agent.CreateDefaultPreferenceDescriptionLine();
thing = agent.SavePreferenceDescriptionLine(thing);
```

