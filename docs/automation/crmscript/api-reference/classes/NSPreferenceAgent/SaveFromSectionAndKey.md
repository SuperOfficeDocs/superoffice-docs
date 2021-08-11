---
uid: crmscript_ref_NSPreferenceAgent_SaveFromSectionAndKey
title: NSPreferenceDescription SaveFromSectionAndKey(String section, String key, NSPreferenceDescription preferenceDescription)
intellisense: NSPreferenceAgent.SaveFromSectionAndKey
keywords: NSPreferenceAgent, SaveFromSectionAndKey
so.topic: reference
---

# NSPreferenceDescription SaveFromSectionAndKey(String section, String key, NSPreferenceDescription preferenceDescription)

Update a NSPreferenceDescription based on the section and key

**Parameters:**
 - **section** The NSPreferenceDescription-section
 - **key** The NSPreferenceDescription-key
 - **preferenceDescription** The NSPreferenceDescription to save.

**Returns:** NSPreferenceDescription

```crmscript
NSPreferenceAgent agent;
String section;
String key;
NSPreferenceDescription preferenceDescription;
NSPreferenceDescription res = agent.SaveFromSectionAndKey(section, key, preferenceDescription);
```

