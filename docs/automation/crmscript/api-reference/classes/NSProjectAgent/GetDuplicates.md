---
uid: crmscript_ref_NSProjectAgent_GetDuplicates
title: NSDuplicateEntry[] GetDuplicates(String name)
intellisense: NSProjectAgent.GetDuplicates
keywords: NSProjectAgent, GetDuplicates
so.topic: reference
---

# NSDuplicateEntry[] GetDuplicates(String name)

Get duplicates(exact or similar in the database) based on the name

**Parameters:**
 - **name** Name used for lookup

**Returns:** NSDuplicateEntry[]

```crmscript
NSProjectAgent agent;
String name;
NSDuplicateEntry[] res = agent.GetDuplicates(name);
```

