---
uid: crmscript_ref_NSPhoneListAgent_SearchWithPreferences
title: NSPhoneListItem[] SearchWithPreferences(String searchString, NSPhoneListPreferences preferences)
intellisense: NSPhoneListAgent.SearchWithPreferences
keywords: NSPhoneListAgent, SearchWithPreferences
so.topic: reference
---

# NSPhoneListItem[] SearchWithPreferences(String searchString, NSPhoneListPreferences preferences)

Searching the phone list. Search is based on the supplied preferences.

**Parameters:**
 - **searchString** The search string.
 - **preferences** The search preferences

**Returns:** The resulting phone list.

```crmscript
NSPhoneListAgent agent;
String searchString;
NSPhoneListPreferences preferences;
NSPhoneListItem[] res = agent.SearchWithPreferences(searchString, preferences);
```

