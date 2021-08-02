---
uid: crmscript_ref_NSContactAgent_GetMyRecentContacts
title: NSContact[] GetMyRecentContacts(Integer sourceType)
intellisense: NSContactAgent.GetMyRecentContacts
keywords: NSContactAgent, GetMyRecentContacts
so.topic: reference
---

Method that returns a set of initial contacts. This could be the contacts in a favorites selection, the history list, the diary, or from all sources. If retrieved from the diary it will get appointments for the current and the next day.

**Parameters:**
 - **sourceType** The source where the contacts are retrieved from (Favorites, History, Diary)
     - Enum: 0 = Unknown 
     - Enum: 1 = History 
     - Enum: 2 = Diary 
     - Enum: 4 = Favorites 
     - Enum: 7 = All 

**Returns:** NSContact[]

```crmscript
NSContactAgent agent;
Integer sourceType;
NSContact[] res = agent.GetMyRecentContacts(sourceType);
```

