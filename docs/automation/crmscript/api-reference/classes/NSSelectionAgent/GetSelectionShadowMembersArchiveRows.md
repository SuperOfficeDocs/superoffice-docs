---
uid: crmscript_ref_NSSelectionAgent_GetSelectionShadowMembersArchiveRows
title: NSArchiveListItem[] GetSelectionShadowMembersArchiveRows(Integer selectionId, String select)
intellisense: NSSelectionAgent.GetSelectionShadowMembersArchiveRows
keywords: NSSelectionAgent, GetSelectionShadowMembersArchiveRows
so.topic: reference
---

Get the list of members in this selection's shadow (i.e. the list of contacts + persons referenced in the main selection).

**Parameters:**
 - **selectionId** The selectionId we want selection members for.
 - **select** (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname,name', 'startTime,firstname,name'

**Returns:** NSArchiveListItem[]

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String select;
NSArchiveListItem[] res = agent.GetSelectionShadowMembersArchiveRows(selectionId, select);
```

