---
title: crmscript_ref_NSPreferenceAgent_GetAllFromSection
description: PreferenceDescriptionArray GetAllFromSection(String section)
intellisense: NSPreferenceAgent.GetAllFromSection
keywords: NSPreferenceAgent,GetAllFromSection
so.topic: reference
---

Gets all PreferenceDescription-items in the specified section

**Parameters:**
 - **section** The PreferenceDescription-section

**Returns:** All PreferenceDescriptions found.

```crmscript
NSPreferenceAgent agent;
String section;
PreferenceDescriptionArray res = agent.GetAllFromSection(section);
```

