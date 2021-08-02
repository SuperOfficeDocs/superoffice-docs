---
uid: crmscript_ref_NSDocumentAgent_GetPublishedProjectDocuments
title: NSDocument[] GetPublishedProjectDocuments(Integer projectId)
intellisense: NSDocumentAgent.GetPublishedProjectDocuments
keywords: NSDocumentAgent, GetPublishedProjectDocuments
so.topic: reference
---

Get published appointment documents by project id.

**Parameters:**
 - **projectId** The project id

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer projectId;
NSDocument[] res = agent.GetPublishedProjectDocuments(projectId);
```

