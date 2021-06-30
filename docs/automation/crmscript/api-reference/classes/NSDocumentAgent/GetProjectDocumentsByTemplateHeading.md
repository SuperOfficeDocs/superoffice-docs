---
uid: crmscript_ref_NSDocumentAgent_GetProjectDocumentsByTemplateHeading
title: Document[] GetProjectDocumentsByTemplateHeading(Integer projectId, DateTime startTime, DateTime endTime, Integer count, Integer templateHeadingId)
intellisense: NSDocumentAgent.GetProjectDocumentsByTemplateHeading
keywords: NSDocumentAgent, GetProjectDocumentsByTemplateHeading
so.topic: reference
---

Method that returns a specified number of document appointments within a time range, filtered by document template heading. The document appointments belong to the project specified. The heading represents a grouping or filtering of document templates.

**Parameters:**
 - **projectId** The project id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **templateHeadingId** The document template heading id. The heading represents a grouping or filtering of document templates.

**Returns:** Array of Appointments.

```crmscript
NSDocumentAgent agent;
Integer projectId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer templateHeadingId;
Document[] res = agent.GetProjectDocumentsByTemplateHeading(projectId, startTime, endTime, count, templateHeadingId);
```

