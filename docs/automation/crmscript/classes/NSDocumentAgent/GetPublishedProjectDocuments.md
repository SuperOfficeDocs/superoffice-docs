---
title: crmscript_ref_NSDocumentAgent_GetPublishedProjectDocuments
description: DocumentArray GetPublishedProjectDocuments(Integer projectId)
intellisense: NSDocumentAgent.GetPublishedProjectDocuments
keywords: NSDocumentAgent,GetPublishedProjectDocuments
so.topic: reference
---

Get published appointment documents by project id.

**Parameters:**
 - **projectId** The project id

**Returns:** Array of Appointment

```crmscript
NSDocumentAgent agent;
Integer projectId;
DocumentArray res = agent.GetPublishedProjectDocuments(projectId);
```

