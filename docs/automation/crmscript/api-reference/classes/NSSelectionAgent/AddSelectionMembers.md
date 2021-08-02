---
uid: crmscript_ref_NSSelectionAgent_AddSelectionMembers
title: Integer AddSelectionMembers(Integer selectionId, Integer[] ids)
intellisense: NSSelectionAgent.AddSelectionMembers
keywords: NSSelectionAgent, AddSelectionMembers
so.topic: reference
---

Add selection members to a static selection of type others than contacts.

**Parameters:**
 - **selectionId** The selection id to add the members to.
 - **ids** Collection of ids to add to the selection.

**Returns:** Integer

```crmscript
NSSelectionAgent agent;
Integer selectionId;
Integer[] ids;
Integer res = agent.AddSelectionMembers(selectionId, ids);
```

