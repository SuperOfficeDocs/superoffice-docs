---
uid: crmscript_ref_NSDocumentAgent_GetPublishedDocuments
title: DocumentArray GetPublishedDocuments(IntegerArray documentIds)
intellisense: NSDocumentAgent.GetPublishedDocuments
keywords: NSDocumentAgent, GetPublishedDocuments
so.topic: reference
---

Get the published documents from an array of doucment ids.

**Parameters:**
 - **documentIds** Array of document ids.

**Returns:** Array of Document

```crmscript
NSDocumentAgent agent;
IntegerArray documentIds;
DocumentArray res = agent.GetPublishedDocuments(documentIds);
```

