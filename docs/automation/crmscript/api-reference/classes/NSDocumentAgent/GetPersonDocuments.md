---
uid: crmscript_ref_NSDocumentAgent_GetPersonDocuments
title: NSDocument[] GetPersonDocuments(Integer personId)
intellisense: NSDocumentAgent.GetPersonDocuments
keywords: NSDocumentAgent, GetPersonDocuments
so.topic: reference
---

# NSDocument[] GetPersonDocuments(Integer personId)

Get all documents that are linked to the person. I.e. the documents that are listed in the person dialog.

**Parameters:**
 - **personId** The person id.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer personId;
NSDocument[] res = agent.GetPersonDocuments(personId);
```

