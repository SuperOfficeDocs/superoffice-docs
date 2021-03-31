---
title: crmscript_ref_NSPhoneListAgent_SearchWithPreferences
description: PhoneListItemArray SearchWithPreferences(String searchString, PhoneListPreferences preferences)
intellisense: NSPhoneListAgent.SearchWithPreferences
keywords: NSPhoneListAgent,SearchWithPreferences
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
PhoneListItemArray res = agent.SearchWithPreferences(searchString, preferences);
```

