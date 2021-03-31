---
title: crmscript_ref_NSProjectAgent_GetDuplicates
description: DuplicateEntryArray GetDuplicates(String name)
intellisense: NSProjectAgent.GetDuplicates
keywords: NSProjectAgent,GetDuplicates
so.topic: reference
---

Get duplicates(exact or similar in the database) based on the name

**Parameters:**
 - **name** Name used for lookup

**Returns:** Any records matching the specified name

```crmscript
NSProjectAgent agent;
String name;
DuplicateEntryArray res = agent.GetDuplicates(name);
```

