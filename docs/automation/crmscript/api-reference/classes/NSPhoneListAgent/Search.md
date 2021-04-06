---
uid: crmscript_ref_NSPhoneListAgent_Search
title: PhoneListItemArray Search(String searchString)
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
PhoneListItemArray res = agent.Search(searchString);
```

