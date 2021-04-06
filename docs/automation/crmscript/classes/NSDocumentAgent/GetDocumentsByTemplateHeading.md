---
uid: crmscript_ref_NSDocumentAgent_GetDocumentsByTemplateHeading
title: DocumentArray GetDocumentsByTemplateHeading(Integer templateHeadingId)
intellisense: NSDocumentAgent.GetDocumentsByTemplateHeading
keywords: NSDocumentAgent, GetDocumentsByTemplateHeading
so.topic: reference
---

Method that returns document appointments, filtered by the document template heading. The heading represents a grouping or filtering of document templates.

**Parameters:**
 - **templateHeadingId** The document template heading id. The heading represents a grouping or filtering of document templates.

**Returns:** Array of Appointments.

```crmscript
NSDocumentAgent agent;
Integer templateHeadingId;
DocumentArray res = agent.GetDocumentsByTemplateHeading(templateHeadingId);
```

