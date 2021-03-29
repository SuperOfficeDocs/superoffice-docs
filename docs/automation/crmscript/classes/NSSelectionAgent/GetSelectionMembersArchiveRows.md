---
title: crmscript_ref_NSSelectionAgent_GetSelectionMembersArchiveRows_Integer_p_0_String_p_1
description: NSSelectionAgent.GetSelectionMembersArchiveRows(Integer p_0, String p_1)
intellisense: NSSelectionAgent.GetSelectionMembersArchiveRows
keywords: GetSelectionMembersArchiveRows(Integer,String)
so.topic: reference
---


Get the list of members in this selection. The type of members depends on the target table of the selection.



* **selectionId:** The selectionId we want selection members for.
* **select:** (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname', 'startTime'
* **Returns:** Array of archive rows, where each item represents one row of data (row level data + the requested columns). NULL if selection does not exist.


