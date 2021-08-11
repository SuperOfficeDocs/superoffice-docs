---
uid: crmscript_ref_NSPhoneListAgent_Search
title: NSPhoneListItem[] Search(String searchString)
intellisense: NSPhoneListAgent.Search
keywords: NSPhoneListAgent, Search
so.topic: reference
---

# NSPhoneListItem[] Search(String searchString)

Searching the phone list. Using default search preferences or the preferences already set by the NSPhoneListPreferences Service

**Parameters:**
 - **searchString** The search string

**Returns:** The resulting phone list

```crmscript
NSPhoneListAgent agent;
String searchString;
NSPhoneListItem[] res = agent.Search(searchString);
```

