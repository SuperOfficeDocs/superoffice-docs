---
title: crmscript_ref_NSDocumentAgent_UndoCheckoutDocument
description: ReturnInfo UndoCheckoutDocument(Integer documentId, StringArray allowedReturnTypes)
intellisense: NSDocumentAgent.UndoCheckoutDocument
keywords: NSDocumentAgent,UndoCheckoutDocument
so.topic: reference
---

Undo (abandon) a checkout

**Parameters:**
 - **documentId** SuperOffice document ID
 - **allowedReturnTypes** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.<br/>An empty array implies that the client places no restriction on possible return action requests.

**Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.

```crmscript
NSDocumentAgent agent;
Integer documentId;
StringArray allowedReturnTypes;
ReturnInfo res = agent.UndoCheckoutDocument(documentId, allowedReturnTypes);
```

