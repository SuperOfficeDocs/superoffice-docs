---
title: NSArchiveListItem[] GetSelectionMembersArchiveRows(Integer selectionId, String select)
path: /EJScript/Classes/NSSelectionAgent/Member functions/NSArchiveListItem[] GetSelectionMembersArchiveRows(Integer p_0, String p_1)
intellisense: 1
classref: 1
keywords: GetSelectionMembersArchiveRows(Integer,String)
---


Get the list of members in this selection. The type of members depends on the target table of the selection.



* **selectionId:** The selectionId we want selection members for.
* **select:** (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname', 'startTime'
* **Returns:** Array of archive rows, where each item represents one row of data (row level data + the requested columns). NULL if selection does not exist.


