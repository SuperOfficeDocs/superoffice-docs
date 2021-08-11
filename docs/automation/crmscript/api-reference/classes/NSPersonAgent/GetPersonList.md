---
uid: crmscript_ref_NSPersonAgent_GetPersonList
title: NSPerson[] GetPersonList(Integer[]  personIds);
intellisense: NSPersonAgent.GetPersonList
keywords: NSPersonAgent, GetPersonList
so.topic: reference
---

# NSPerson[] GetPersonList(Integer[]  personIds);

Gets a vector of NSPerson objects.

**Parameters:**
 - **personIds** The identifiers of the NSPerson objects

**Returns:** NSPerson[]

```crmscript
Integer[] ids;
NSPersonAgent agent;
agent.GetPersonList(ids);
```

