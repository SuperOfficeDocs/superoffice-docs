---
uid: crmscript_ref_NSContactAgent_GetDuplicates
title: DuplicateEntry[] GetDuplicates(String name)
intellisense: NSContactAgent.GetDuplicates
keywords: NSContactAgent, GetDuplicates
so.topic: reference
---

Get duplicates (exact or similar in the database) based on the name

**Parameters:**
 - **name** Name used for lookup

**Returns:** Any records matching the specified name

```crmscript
NSContactAgent agent;
String name;
DuplicateEntry[] res = agent.GetDuplicates(name);
```

