---
title: crmscript_ref_NSDocumentAgent_GetPublishedPersonDocumentsByDate
description: DocumentArray GetPublishedPersonDocumentsByDate(Integer personId, Bool includeProjectDocuments, DateTime startTime, DateTime endTime, Integer count)
intellisense: NSDocumentAgent.GetPublishedPersonDocumentsByDate
keywords: NSDocumentAgent,GetPublishedPersonDocumentsByDate
so.topic: reference
---

Method that returns a specified number of published document appointments within a time range. The document appointments belong to the person specified or the document is in a project the person belongs to. 

**Parameters:**
 - **personId** The person id of the SuperOffice user (associate).
 - **includeProjectDocuments** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** Array of Appointments.

```crmscript
NSDocumentAgent agent;
Integer personId;
Bool includeProjectDocuments;
DateTime startTime;
DateTime endTime;
Integer count;
DocumentArray res = agent.GetPublishedPersonDocumentsByDate(personId, includeProjectDocuments, startTime, endTime, count);
```

