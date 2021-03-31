---
title: crmscript_ref_NSDocumentAgent_GetProjectMemberDocumentsByTemplateHeading
description: DocumentArray GetProjectMemberDocumentsByTemplateHeading(Integer personId, DateTime startTime, DateTime endTime, Integer count, Integer templateHeadingId)
intellisense: NSDocumentAgent.GetProjectMemberDocumentsByTemplateHeading
keywords: NSDocumentAgent,GetProjectMemberDocumentsByTemplateHeading
so.topic: reference
---

Method that returns a specified number of document appointments within a time range, filtered by document template heading. The document appointments belong to the project member specified. The heading represents a grouping or filtering of document templates.

**Parameters:**
 - **personId** The project member's person id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **templateHeadingId** The document template heading id. The heading represents a grouping or filtering of document templates.

**Returns:** Array of Appointments.

```crmscript
NSDocumentAgent agent;
Integer personId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer templateHeadingId;
DocumentArray res = agent.GetProjectMemberDocumentsByTemplateHeading(personId, startTime, endTime, count, templateHeadingId);
```

