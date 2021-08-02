---
uid: crmscript_ref_NSPreferenceAgent_GetFromSectionAndKey
title: NSPreferenceDescription GetFromSectionAndKey(String section, String key)
intellisense: NSPreferenceAgent.GetFromSectionAndKey
keywords: NSPreferenceAgent, GetFromSectionAndKey
so.topic: reference
---

Gets a NSPreferenceDescription based on the section and key

**Parameters:**
 - **section** The PreferenceDescription-section
 - **key** The PreferenceDescription-key

**Returns:** NSPreferenceDescription

```crmscript
NSPreferenceAgent agent;
String section;
String key;
NSPreferenceDescription res = agent.GetFromSectionAndKey(section, key);
```

