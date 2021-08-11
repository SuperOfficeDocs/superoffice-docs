---
uid: crmscript_ref_NSViewStateAgent_GetHistoriesByNamesAndIds
title: NSHistory[] GetHistoriesByNamesAndIds(NSHistoryRequest[] requests)
intellisense: NSViewStateAgent.GetHistoriesByNamesAndIds
keywords: NSViewStateAgent, GetHistoriesByNamesAndIds
so.topic: reference
---

# NSHistory[] GetHistoriesByNamesAndIds(NSHistoryRequest[] requests)

Returns history data for the named entities and the given ids - which may not directly correspond to the current history records in the database.<para/>Use this method if you know exactly which items you need, regardless of whether they are in the current history or not.<para/>The history in the database is not changed or even looked at by this method.

**Parameters:**
 - **requests** Array of request objects that define what entities we are requesting history information for

**Returns:** NSHistory[]

```crmscript
NSViewStateAgent agent;
NSHistoryRequest[] requests;
NSHistory[] res = agent.GetHistoriesByNamesAndIds(requests);
```

