---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateTask
title: Task GetDocumentTemplateTask(Integer documentTemplateId)
intellisense: NSListAgent.GetDocumentTemplateTask
keywords: NSListAgent, GetDocumentTemplateTask
so.topic: reference
---

Returns a Document Template list item as a TaskListItem. The appointment's task is a Document template item when the appointment is a document.

**Parameters:**
 - **documentTemplateId** Id of the document template, i.e. the Appointment.TaskIdx

**Returns:** Document Template item as TaskListItem.

```crmscript
NSListAgent agent;
Integer documentTemplateId;
Task res = agent.GetDocumentTemplateTask(documentTemplateId);
```

