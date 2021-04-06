---
uid: crmscript_ref_NSViewStateAgent_SaveHistories
title: HistoryArray SaveHistories(String historyName, HistoryArray history)
intellisense: NSViewStateAgent.SaveHistories
keywords: NSViewStateAgent, SaveHistories
so.topic: reference
---

Replaces the existing history-list for the currently logged in user. All elements must belong to the same history list. If not they are ignored.

**Parameters:**
 - **historyName** 
 - **history** Array of new history items to save.

**Returns:** Array of the saved History items

```crmscript
NSViewStateAgent agent;
String historyName;
HistoryArray history;
HistoryArray res = agent.SaveHistories(historyName, history);
```

