---
uid: crmscript_ref_NSContactAgent_GetDuplicates
title: NSDuplicateEntry[] GetDuplicates(String name)
intellisense: NSContactAgent.GetDuplicates
keywords: NSContactAgent, GetDuplicates
so.topic: reference
---

# NSDuplicateEntry[] GetDuplicates(String name)

Get duplicates (exact or similar in the database) based on the name

**Parameters:**
 - **name** Name used for lookup

**Returns:** NSDuplicateEntry[]

```crmscript
NSContactAgent agent;
String name;
NSDuplicateEntry[] res = agent.GetDuplicates(name);
```

