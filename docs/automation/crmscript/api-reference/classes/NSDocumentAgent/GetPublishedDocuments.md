---
uid: crmscript_ref_NSDocumentAgent_GetPublishedDocuments
title: NSDocument[] GetPublishedDocuments(Integer[] documentIds)
intellisense: NSDocumentAgent.GetPublishedDocuments
keywords: NSDocumentAgent, GetPublishedDocuments
so.topic: reference
---

Get the published documents from an array of doucment ids.

**Parameters:**
 - **documentIds** Array of document ids.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer[] documentIds;
NSDocument[] res = agent.GetPublishedDocuments(documentIds);
```

