---
uid: crmscript_ref_NSDocumentAgent_GetPersonDocuments
title: Document[] GetPersonDocuments(Integer personId)
intellisense: NSDocumentAgent.GetPersonDocuments
keywords: NSDocumentAgent, GetPersonDocuments
so.topic: reference
---

Get all documents that are linked to the person. I.e. the documents that are listed in the person dialog.

**Parameters:**
 - **personId** The person id.

**Returns:** Array of documents

```crmscript
NSDocumentAgent agent;
Integer personId;
Document[] res = agent.GetPersonDocuments(personId);
```

