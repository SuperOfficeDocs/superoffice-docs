---
uid: crmscript_ref_NSContactAgent_GetMyActiveContacts
title: NSContactActivity[] GetMyActiveContacts(DateTime activityStartTime, Integer[] contactCategories, Integer actionType)
intellisense: NSContactAgent.GetMyActiveContacts
keywords: NSContactAgent, GetMyActiveContacts
so.topic: reference
---

Returns the contacts where there has been activity since activityStartTime. If activityStartTime is larger than the current date, all contacts with activity since last log-out are returned. The result set can be filtered by category and action type.

**Parameters:**
 - **activityStartTime** The start time of the activities. If the start time is set to a future date; activites since the user last logged out are returned.
 - **contactCategories** Integer array of categories to filter on. If the array is empty contacts from all categories will be selected.
 - **actionType** The type of action that has occured. E.g. updates, deletes, new appointments, etc.
     - Enum: 0 = Unknown 
     - Enum: 1 = Created 
     - Enum: 2 = Updated 
     - Enum: 4 = NewActivity 
     - Enum: 8 = ActivityCompleted 
     - Enum: 16 = PersonAdded 
     - Enum: 32 = PersonUpdated 
     - Enum: 64 = DocumentAdded 
     - Enum: 127 = All 

**Returns:** NSContactActivity[]

```crmscript
NSContactAgent agent;
DateTime activityStartTime;
Integer[] contactCategories;
Integer actionType;
NSContactActivity[] res = agent.GetMyActiveContacts(activityStartTime, contactCategories, actionType);
```

