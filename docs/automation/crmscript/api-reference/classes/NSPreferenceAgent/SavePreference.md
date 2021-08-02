---
uid: crmscript_ref_NSPreferenceAgent_SavePreference
title: Void SavePreference(NSPreference preference)
intellisense: NSPreferenceAgent.SavePreference
keywords: NSPreferenceAgent, SavePreference
so.topic: reference
---

Save this preference

**Parameters:**
 - **preference** Preference to be saved. All fields must be filled in, and the preference will be saved on the Associate level only. Setting for other levels is an administrative task and not available through this service.

```crmscript
NSPreferenceAgent agent;
NSPreference preference;
agent.SavePreference(preference);
```

