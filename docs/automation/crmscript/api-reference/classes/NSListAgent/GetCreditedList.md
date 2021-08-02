---
uid: crmscript_ref_NSListAgent_GetCreditedList
title: NSCredited[] GetCreditedList(Integer[]  creditedIds);
intellisense: NSListAgent.GetCreditedList
keywords: NSListAgent, GetCreditedList
so.topic: reference
---

Gets a vector of NSCredited objects.

**Parameters:**
 - **creditedIds** The identifiers of the NSCredited objects

**Returns:** NSCredited[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSCredited[] res = agent.GetCreditedList(ids);
```

