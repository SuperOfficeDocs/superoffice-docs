---
uid: crmscript_ref_NSPhoneListAgent_SearchWithPreferences
title: PhoneListItem[] SearchWithPreferences(String searchString, PhoneListPreferences preferences)
intellisense: NSPhoneListAgent.SearchWithPreferences
keywords: NSPhoneListAgent, SearchWithPreferences
so.topic: reference
---

Searching the phone list. Search is based on the supplied preferences.

**Parameters:**
 - **searchString** The search string.
 - **preferences** The search preferences

**Returns:** The resulting phone list.

```crmscript
NSPhoneListAgent agent;
String searchString;
PhoneListPreferences preferences;
PhoneListItem[] res = agent.SearchWithPreferences(searchString, preferences);
```

