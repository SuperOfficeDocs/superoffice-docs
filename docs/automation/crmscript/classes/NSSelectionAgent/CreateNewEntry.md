---
uid: crmscript_ref_NSSelectionAgent_CreateNewEntry
title: Integer CreateNewEntry(DuplicateEntry duplicate)
intellisense: NSSelectionAgent.CreateNewEntry
keywords: NSSelectionAgent, CreateNewEntry
so.topic: reference
---

Creates a new selection based on external duplicate

**Parameters:**
 - **duplicate** The duplicate to create a new entry based upon

**Returns:** The database identity of the newly created entry

```crmscript
NSSelectionAgent agent;
DuplicateEntry duplicate;
Integer res = agent.CreateNewEntry(duplicate);
```

