---
title: crmscript_ref_NSSelectionAgent_GetSelectionMembersArchiveRows
description: ArchiveListItemArray GetSelectionMembersArchiveRows(Integer selectionId, String select)
intellisense: NSSelectionAgent.GetSelectionMembersArchiveRows
keywords: NSSelectionAgent,GetSelectionMembersArchiveRows
so.topic: reference
---

Get the list of members in this selection. The type of members depends on the target table of the selection.

**Parameters:**
 - **selectionId** The selectionId we want selection members for.
 - **select** (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname', 'startTime'

**Returns:** Array of archive rows, where each item represents one row of data (row level data + the requested columns). NULL if selection does not exist.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String select;
ArchiveListItemArray res = agent.GetSelectionMembersArchiveRows(selectionId, select);
```

