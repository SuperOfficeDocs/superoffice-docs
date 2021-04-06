---
uid: crmscript_ref_NSPreferenceAgent_SaveFromSectionAndKey
title: PreferenceDescription SaveFromSectionAndKey(String section, String key, PreferenceDescription preferenceDescription)
intellisense: NSPreferenceAgent.SaveFromSectionAndKey
keywords: NSPreferenceAgent, SaveFromSectionAndKey
so.topic: reference
---

Update a PreferenceDescription based on the section and key

**Parameters:**
 - **section** The PreferenceDescription-section
 - **key** The PreferenceDescription-key
 - **preferenceDescription** The PreferenceDescription to save.

**Returns:** Saved PreferenceDescription

```crmscript
NSPreferenceAgent agent;
String section;
String key;
PreferenceDescription preferenceDescription;
PreferenceDescription res = agent.SaveFromSectionAndKey(section, key, preferenceDescription);
```

