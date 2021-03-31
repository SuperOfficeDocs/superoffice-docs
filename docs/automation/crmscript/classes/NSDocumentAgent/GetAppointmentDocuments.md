---
title: crmscript_ref_NSDocumentAgent_GetAppointmentDocuments
description: DocumentArray GetAppointmentDocuments(Integer appointmentId)
intellisense: NSDocumentAgent.GetAppointmentDocuments
keywords: NSDocumentAgent,GetAppointmentDocuments
so.topic: reference
---

Get all documents that are linked to the appointment. I.e. the documents that are listed in the appointment dialog.

**Parameters:**
 - **appointmentId** The appointment id.

**Returns:** Array of documents

```crmscript
NSDocumentAgent agent;
Integer appointmentId;
DocumentArray res = agent.GetAppointmentDocuments(appointmentId);
```

