---
uid: crmscript_ref_NSSelectionAgent_GetSelectionMembersArchiveRows
title: NSArchiveListItem[] GetSelectionMembersArchiveRows(Integer selectionId, String select)
intellisense: NSSelectionAgent.GetSelectionMembersArchiveRows
keywords: NSSelectionAgent, GetSelectionMembersArchiveRows
so.topic: reference
---

# NSArchiveListItem[] GetSelectionMembersArchiveRows(Integer selectionId, String select)

Get the list of members in this selection. The type of members depends on the target table of the selection.

**Parameters:**
 - **selectionId** The selectionId we want selection members for.
 - **select** (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname', 'startTime'

**Returns:** NSArchiveListItem[]

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String select;
NSArchiveListItem[] res = agent.GetSelectionMembersArchiveRows(selectionId, select);
```

