---
title: crmscript_ref_NSSelectionAgent_UpdateTypicalSearch
description: String UpdateTypicalSearch(TypicalSearches searches)
intellisense: NSSelectionAgent.UpdateTypicalSearch
keywords: NSSelectionAgent,UpdateTypicalSearch
so.topic: reference
---

Update (import) TypicalSearch information in the database

**Parameters:**
 - **searches** TypicalSearch structures to import. If null, then the fileset is scanned for *TypicalSearch.json files and those are imported instead

**Returns:** Message that can be shown to the user, summarizing what has been done, if anything.

```crmscript
NSSelectionAgent agent;
TypicalSearches searches;
String res = agent.UpdateTypicalSearch(searches);
```

