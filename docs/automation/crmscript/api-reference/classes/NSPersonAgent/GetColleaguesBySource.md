---
uid: crmscript_ref_NSPersonAgent_GetColleaguesBySource
title: NSPerson[] GetColleaguesBySource(Integer sourceType, Integer count)
intellisense: NSPersonAgent.GetColleaguesBySource
keywords: NSPersonAgent, GetColleaguesBySource
so.topic: reference
---

Gets the persons working in the same company as the logged on user. The list of person could be retrieved from the history list, the diary view list, or from all sources.

**Parameters:**
 - **sourceType** The “source” the colleagues should be retrieved from. <see cref="AssociateSourceType"/> for more information.
     - Enum: 0 = Unknown 
     - Enum: 1 = NSHistory 
     - Enum: 2 = DiaryViewList 
     - Enum: 4 = Department 
     - Enum: 7 = All 
 - **count** 

**Returns:** NSPerson[]

```crmscript
NSPersonAgent agent;
Integer sourceType;
Integer count;
NSPerson[] res = agent.GetColleaguesBySource(sourceType, count);
```

