---
title: NSArchiveListItem[] GetSelectionShadowMembersArchiveRows(Integer selectionId, String select)
path: /EJScript/Classes/NSSelectionAgent/Member functions/NSArchiveListItem[] GetSelectionShadowMembersArchiveRows(Integer p_0, String p_1)
intellisense: 1
classref: 1
sortOrder: 7357
keywords: GetSelectionShadowMembersArchiveRows(Integer,String)
---


Get the list of members in this selection's shadow (i.e. the list of contacts + persons referenced in the main selection).



* **selectionId:** The selectionId we want selection members for.
* **select:** (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname,name', 'startTime,firstname,name'
* **Returns:** Array of archive rows, where each item represents one row of data (row level data + the requested columns). NULL if selection does not exist.


