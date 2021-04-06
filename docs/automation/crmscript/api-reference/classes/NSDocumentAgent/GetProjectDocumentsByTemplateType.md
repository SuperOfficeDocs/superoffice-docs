---
uid: crmscript_ref_NSDocumentAgent_GetProjectDocumentsByTemplateType
title: DocumentArray GetProjectDocumentsByTemplateType(Integer projectId, DateTime startTime, DateTime endTime, Integer count, Integer documentTemplateId)
intellisense: NSDocumentAgent.GetProjectDocumentsByTemplateType
keywords: NSDocumentAgent, GetProjectDocumentsByTemplateType
so.topic: reference
---

Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the project specified. 

**Parameters:**
 - **projectId** The project id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **documentTemplateId** Id of the document template type to filter on.

**Returns:** Array of Appointments.

```crmscript
NSDocumentAgent agent;
Integer projectId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer documentTemplateId;
DocumentArray res = agent.GetProjectDocumentsByTemplateType(projectId, startTime, endTime, count, documentTemplateId);
```

