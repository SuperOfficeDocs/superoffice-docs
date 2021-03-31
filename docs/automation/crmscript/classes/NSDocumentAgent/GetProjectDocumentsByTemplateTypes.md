---
title: crmscript_ref_NSDocumentAgent_GetProjectDocumentsByTemplateTypes
description: DocumentArray GetProjectDocumentsByTemplateTypes(Integer projectId, DateTime startTime, DateTime endTime, Integer count, IntegerArray documentTemplateIds)
intellisense: NSDocumentAgent.GetProjectDocumentsByTemplateTypes
keywords: NSDocumentAgent,GetProjectDocumentsByTemplateTypes
so.topic: reference
---

Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the project specified. 

**Parameters:**
 - **projectId** The project id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **documentTemplateIds** Ids of the document template types to filter on.

**Returns:** Array of Appointments.

```crmscript
NSDocumentAgent agent;
Integer projectId;
DateTime startTime;
DateTime endTime;
Integer count;
IntegerArray documentTemplateIds;
DocumentArray res = agent.GetProjectDocumentsByTemplateTypes(projectId, startTime, endTime, count, documentTemplateIds);
```

