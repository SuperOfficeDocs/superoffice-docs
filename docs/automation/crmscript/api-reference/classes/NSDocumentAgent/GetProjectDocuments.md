---
uid: crmscript_ref_NSDocumentAgent_GetProjectDocuments
title: NSDocument[] GetProjectDocuments(Integer projectId, DateTime startTime, DateTime endTime, Integer count)
intellisense: NSDocumentAgent.GetProjectDocuments
keywords: NSDocumentAgent, GetProjectDocuments
so.topic: reference
---

# NSDocument[] GetProjectDocuments(Integer projectId, DateTime startTime, DateTime endTime, Integer count)

Method that returns a specified number of document appointments within a time range. The document appointments belong to the project specified. 

**Parameters:**
 - **projectId** The project id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer projectId;
DateTime startTime;
DateTime endTime;
Integer count;
NSDocument[] res = agent.GetProjectDocuments(projectId, startTime, endTime, count);
```

