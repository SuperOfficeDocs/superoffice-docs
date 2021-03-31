---
uid: crmscript_ref_NSPersonAgent_GetPersonList
title: NSPerson[] GetPersonList(Integer[]  personIds);
intellisense: NSPersonAgent.GetPersonList
keywords: NSPersonAgent, GetPersonList
so.topic: reference
---

Gets a vector of Person objects.

**Parameters:**
 - **personIds** The identifiers of the NSPerson objects

**Returns:** Vector of NSPerson objects

```crmscript
Integer[] ids;
NSPersonAgent agent;
agent.GetPersonList(ids);
```

