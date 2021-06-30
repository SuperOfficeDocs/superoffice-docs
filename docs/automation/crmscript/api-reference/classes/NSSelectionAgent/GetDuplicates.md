---
uid: crmscript_ref_NSSelectionAgent_GetDuplicates
title: DuplicateEntry[] GetDuplicates(String name)
intellisense: NSSelectionAgent.GetDuplicates
keywords: NSSelectionAgent, GetDuplicates
so.topic: reference
---

Get duplicates(exact or similar in the database) based on the name

**Parameters:**
 - **name** Name used for lookup

**Returns:** Any records matching the specified name

```crmscript
NSSelectionAgent agent;
String name;
DuplicateEntry[] res = agent.GetDuplicates(name);
```

