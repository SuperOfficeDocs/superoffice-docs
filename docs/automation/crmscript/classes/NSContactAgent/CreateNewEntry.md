---
title: crmscript_ref_NSContactAgent_CreateNewEntry
description: Integer CreateNewEntry(DuplicateEntry duplicate)
intellisense: NSContactAgent.CreateNewEntry
keywords: NSContactAgent,CreateNewEntry
so.topic: reference
---

Creates a new contact based on external duplicate

**Parameters:**
 - **duplicate** The duplicate to create a new entry based upon

**Returns:** The database identity of the newly created entry

```crmscript
NSContactAgent agent;
DuplicateEntry duplicate;
Integer res = agent.CreateNewEntry(duplicate);
```

