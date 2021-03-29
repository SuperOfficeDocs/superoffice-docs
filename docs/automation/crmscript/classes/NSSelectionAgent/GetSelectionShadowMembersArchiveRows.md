---
title: crmscript_ref_NSSelectionAgent_GetSelectionShadowMembersArchiveRows_Integer_p_0_String_p_1
description: NSSelectionAgent.GetSelectionShadowMembersArchiveRows(Integer p_0, String p_1)
intellisense: NSSelectionAgent.GetSelectionShadowMembersArchiveRows
keywords: GetSelectionShadowMembersArchiveRows(Integer,String)
so.topic: reference
---


Get the list of members in this selection's shadow (i.e. the list of contacts + persons referenced in the main selection).



* **selectionId:** The selectionId we want selection members for.
* **select:** (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname,name', 'startTime,firstname,name'
* **Returns:** Array of archive rows, where each item represents one row of data (row level data + the requested columns). NULL if selection does not exist.


