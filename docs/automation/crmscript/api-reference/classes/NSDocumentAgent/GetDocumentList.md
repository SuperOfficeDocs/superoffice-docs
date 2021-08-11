---
uid: crmscript_ref_NSDocumentAgent_GetDocumentList
title: NSDocument[] GetDocumentList(Integer[]  documentIds);
intellisense: NSDocumentAgent.GetDocumentList
keywords: NSDocumentAgent, GetDocumentList
so.topic: reference
---

# NSDocument[] GetDocumentList(Integer[]  documentIds);

Gets a vector of NSDocument objects.

**Parameters:**
 - **documentIds** The identifiers of the NSDocument objects

**Returns:** NSDocument[]

```crmscript
Integer[] ids;
NSDocumentAgent agent;
NSDocument[] docs = agent.GetDocumentList(ids);
```

