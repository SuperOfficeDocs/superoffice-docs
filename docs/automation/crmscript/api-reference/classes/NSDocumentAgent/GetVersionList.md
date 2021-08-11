---
uid: crmscript_ref_NSDocumentAgent_GetVersionList
title: NSVersionInfo[] GetVersionList(Integer documentId)
intellisense: NSDocumentAgent.GetVersionList
keywords: NSDocumentAgent, GetVersionList
so.topic: reference
---

# NSVersionInfo[] GetVersionList(Integer documentId)

Get a list of existing, committed  versions for a given document

**Parameters:**
 - **documentId** SuperOffice document Id

**Returns:** NSVersionInfo[]

```crmscript
NSDocumentAgent agent;
Integer documentId;
NSVersionInfo[] res = agent.GetVersionList(documentId);
```

