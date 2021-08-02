---
uid: crmscript_ref_NSSelectionAgent_GetDuplicates
title: NSDuplicateEntry[] GetDuplicates(String name)
intellisense: NSSelectionAgent.GetDuplicates
keywords: NSSelectionAgent, GetDuplicates
so.topic: reference
---

Get duplicates(exact or similar in the database) based on the name

**Parameters:**
 - **name** Name used for lookup

**Returns:** NSDuplicateEntry[]

```crmscript
NSSelectionAgent agent;
String name;
NSDuplicateEntry[] res = agent.GetDuplicates(name);
```

