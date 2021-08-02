---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateTask
title: NSTask GetDocumentTemplateTask(Integer documentTemplateId)
intellisense: NSListAgent.GetDocumentTemplateTask
keywords: NSListAgent, GetDocumentTemplateTask
so.topic: reference
---

Returns a Document Template list item as a TaskListItem. The appointment's task is a Document template item when the appointment is a document.

**Parameters:**
 - **documentTemplateId** Id of the document template, i.e. the Appointment.TaskIdx

**Returns:** NSTask

```crmscript
NSListAgent agent;
Integer documentTemplateId;
NSTask res = agent.GetDocumentTemplateTask(documentTemplateId);
```

