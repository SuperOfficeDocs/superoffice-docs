---
uid: crmscript_ref_NSPreferenceAgent_GetAllFromSection
title: NSPreferenceDescription[] GetAllFromSection(String section)
intellisense: NSPreferenceAgent.GetAllFromSection
keywords: NSPreferenceAgent, GetAllFromSection
so.topic: reference
---

# NSPreferenceDescription[] GetAllFromSection(String section)

Gets all NSPreferenceDescription-items in the specified section

**Parameters:**
 - **section** The PreferenceDescription-section

**Returns:** NSPreferenceDescription[]

```crmscript
NSPreferenceAgent agent;
String section;
NSPreferenceDescription[] res = agent.GetAllFromSection(section);
```

