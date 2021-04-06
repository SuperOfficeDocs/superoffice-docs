---
uid: crmscript_ref_NSPreferenceAgent_GetFromSectionAndKey
title: PreferenceDescription GetFromSectionAndKey(String section, String key)
intellisense: NSPreferenceAgent.GetFromSectionAndKey
keywords: NSPreferenceAgent, GetFromSectionAndKey
so.topic: reference
---

Gets a PreferenceDescription based on the section and key

**Parameters:**
 - **section** The PreferenceDescription-section
 - **key** The PreferenceDescription-key

**Returns:** A PreferenceDescription or null

```crmscript
NSPreferenceAgent agent;
String section;
String key;
PreferenceDescription res = agent.GetFromSectionAndKey(section, key);
```

