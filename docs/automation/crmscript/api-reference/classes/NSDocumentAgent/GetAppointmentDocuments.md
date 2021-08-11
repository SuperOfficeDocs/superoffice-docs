---
uid: crmscript_ref_NSDocumentAgent_GetAppointmentDocuments
title: NSDocument[] GetAppointmentDocuments(Integer appointmentId)
intellisense: NSDocumentAgent.GetAppointmentDocuments
keywords: NSDocumentAgent, GetAppointmentDocuments
so.topic: reference
---

# NSDocument[] GetAppointmentDocuments(Integer appointmentId)

Get all documents that are linked to the appointment. I.e. the documents that are listed in the appointment dialog.

**Parameters:**
 - **appointmentId** The appointment id.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer appointmentId;
NSDocument[] res = agent.GetAppointmentDocuments(appointmentId);
```

