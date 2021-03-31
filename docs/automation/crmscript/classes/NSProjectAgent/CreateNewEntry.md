---
uid: crmscript_ref_NSProjectAgent_CreateNewEntry
title: Integer CreateNewEntry(DuplicateEntry duplicate)
intellisense: NSProjectAgent.CreateNewEntry
keywords: NSProjectAgent, CreateNewEntry
so.topic: reference
---

Creates a new project based on external duplicate

**Parameters:**
 - **duplicate** The duplicate to create a new entry based upon

**Returns:** The database identity of the newly created entry

```crmscript
NSProjectAgent agent;
DuplicateEntry duplicate;
Integer res = agent.CreateNewEntry(duplicate);
```

