---
uid: crmscript_ref_NSPhoneListAgent_Search
title: PhoneListItem[] Search(String searchString)
intellisense: NSPhoneListAgent.Search
keywords: NSPhoneListAgent, Search
so.topic: reference
---

Searching the phone list. Using default search preferences or the preferences already set by the PhoneListPreferences Service

**Parameters:**
 - **searchString** The search string

**Returns:** The resulting phone list

```crmscript
NSPhoneListAgent agent;
String searchString;
PhoneListItem[] res = agent.Search(searchString);
```

