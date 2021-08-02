---
uid: crmscript_ref_NSDocumentAgent_GetPublishedDocumentsByDate
title: NSDocument[] GetPublishedDocumentsByDate(Integer personId, Bool includeProjectDocuments, DateTime startTime, DateTime endTime, Integer count)
intellisense: NSDocumentAgent.GetPublishedDocumentsByDate
keywords: NSDocumentAgent, GetPublishedDocumentsByDate
so.topic: reference
---

Method that returns a specified number of published document appointments within a time range. The document appointments is visible to the person specified or the document is in a project the person belongs to. 

**Parameters:**
 - **personId** The personId
 - **includeProjectDocuments** Include projectDocuments to select documents in projects person is a member of.
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer personId;
Bool includeProjectDocuments;
DateTime startTime;
DateTime endTime;
Integer count;
NSDocument[] res = agent.GetPublishedDocumentsByDate(personId, includeProjectDocuments, startTime, endTime, count);
```

