---
title: crmscript_ref_NSSelectionAgent_AddSelectionMembers
description: Integer AddSelectionMembers(Integer selectionId, IntegerArray ids)
intellisense: NSSelectionAgent.AddSelectionMembers
keywords: NSSelectionAgent,AddSelectionMembers
so.topic: reference
---

Add selection members to a static selection of type others than contacts.

**Parameters:**
 - **selectionId** The selection id to add the members to.
 - **ids** Collection of ids to add to the selection.

**Returns:** Returns number of members added to the selection.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
IntegerArray ids;
Integer res = agent.AddSelectionMembers(selectionId, ids);
```

