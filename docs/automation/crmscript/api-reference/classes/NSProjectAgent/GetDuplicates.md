---
uid: crmscript_ref_NSProjectAgent_GetDuplicates
title: DuplicateEntry[] GetDuplicates(String name)
intellisense: NSProjectAgent.GetDuplicates
keywords: NSProjectAgent, GetDuplicates
so.topic: reference
---

Get duplicates(exact or similar in the database) based on the name

**Parameters:**
 - **name** Name used for lookup

**Returns:** Any records matching the specified name

```crmscript
NSProjectAgent agent;
String name;
DuplicateEntry[] res = agent.GetDuplicates(name);
```

