---
uid: crmscript_ref_NSContactAgent_CreateNewEntry
title: Integer CreateNewEntry(NSDuplicateEntry duplicate)
intellisense: NSContactAgent.CreateNewEntry
keywords: NSContactAgent, CreateNewEntry
so.topic: reference
---

# Integer CreateNewEntry(NSDuplicateEntry duplicate)

Creates a new contact based on external duplicate

**Parameters:**
 - **duplicate** The duplicate to create a new entry based upon

**Returns:** Integer

```crmscript
NSContactAgent agent;
NSDuplicateEntry duplicate;
Integer res = agent.CreateNewEntry(duplicate);
```

