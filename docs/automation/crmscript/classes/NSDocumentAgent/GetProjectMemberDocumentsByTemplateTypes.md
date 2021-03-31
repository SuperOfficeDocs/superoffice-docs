---
title: crmscript_ref_NSDocumentAgent_GetProjectMemberDocumentsByTemplateTypes
description: DocumentArray GetProjectMemberDocumentsByTemplateTypes(Integer personId, DateTime startTime, DateTime endTime, Integer count, IntegerArray documentTemplateIds)
intellisense: NSDocumentAgent.GetProjectMemberDocumentsByTemplateTypes
keywords: NSDocumentAgent,GetProjectMemberDocumentsByTemplateTypes
so.topic: reference
---

Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the project member specified. 

**Parameters:**
 - **personId** The project member's person id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **documentTemplateIds** Ids of the document template types to filter on.

**Returns:** Array of Appointments.

```crmscript
NSDocumentAgent agent;
Integer personId;
DateTime startTime;
DateTime endTime;
Integer count;
IntegerArray documentTemplateIds;
DocumentArray res = agent.GetProjectMemberDocumentsByTemplateTypes(personId, startTime, endTime, count, documentTemplateIds);
```

