---
uid: crmscript_ref_NSDocumentAgent_GetProjectMemberDocumentsByTemplateType
title: Document[] GetProjectMemberDocumentsByTemplateType(Integer personId, DateTime startTime, DateTime endTime, Integer count, Integer documentTemplateId)
intellisense: NSDocumentAgent.GetProjectMemberDocumentsByTemplateType
keywords: NSDocumentAgent, GetProjectMemberDocumentsByTemplateType
so.topic: reference
---

Method that returns a specified number of document appointments within a time range, filtered by document template type. The document appointments belong to the project member specified. 

**Parameters:**
 - **personId** The project member's person id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **documentTemplateId** Id of the document template type to filter on.

**Returns:** Array of Appointments.

```crmscript
NSDocumentAgent agent;
Integer personId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer documentTemplateId;
Document[] res = agent.GetProjectMemberDocumentsByTemplateType(personId, startTime, endTime, count, documentTemplateId);
```

