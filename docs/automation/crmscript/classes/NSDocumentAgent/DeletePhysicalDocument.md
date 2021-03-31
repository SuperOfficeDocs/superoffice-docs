---
title: crmscript_ref_NSDocumentAgent_DeletePhysicalDocument
description: ReturnInfo DeletePhysicalDocument(Integer documentId, StringArray allowedReturnType)
intellisense: NSDocumentAgent.DeletePhysicalDocument
keywords: NSDocumentAgent,DeletePhysicalDocument
so.topic: reference
---

Delete the document contents

**Parameters:**
 - **documentId** document primary key
 - **allowedReturnType** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing. Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.<br/>An empty array implies that the client places no restriction on possible return action requests

**Returns:** Delete status - did removal succeed or not

```crmscript
NSDocumentAgent agent;
Integer documentId;
StringArray allowedReturnType;
ReturnInfo res = agent.DeletePhysicalDocument(documentId, allowedReturnType);
```

