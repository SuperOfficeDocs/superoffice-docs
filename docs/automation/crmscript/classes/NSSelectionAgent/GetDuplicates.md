---
uid: crmscript_ref_NSSelectionAgent_GetDuplicates
title: DuplicateEntryArray GetDuplicates(String name)
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
DuplicateEntryArray res = agent.GetDuplicates(name);
```

