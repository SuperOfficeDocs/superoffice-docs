---
uid: crmscript_ref_NSDocumentAgent_DeletePhysicalDocument
title: NSReturnInfo DeletePhysicalDocument(Integer documentId, String[] allowedReturnType)
intellisense: NSDocumentAgent.DeletePhysicalDocument
keywords: NSDocumentAgent, DeletePhysicalDocument
so.topic: reference
---

Delete the document contents

**Parameters:**
 - **documentId** document primary key
 - **allowedReturnType** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing. Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.<br/>An empty array implies that the client places no restriction on possible return action requests

**Returns:** NSReturnInfo

```crmscript
NSDocumentAgent agent;
Integer documentId;
String[] allowedReturnType;
NSReturnInfo res = agent.DeletePhysicalDocument(documentId, allowedReturnType);
```

