---
uid: crmscript_ref_NSDocumentAgent_GetPublishedDocuments
title: Document[] GetPublishedDocuments(Integer[] documentIds)
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
Integer[] documentIds;
Document[] res = agent.GetPublishedDocuments(documentIds);
```

