---
uid: crmscript_ref_NSDocumentAgent_UndoCheckoutDocument
title: NSReturnInfo UndoCheckoutDocument(Integer documentId, String[] allowedReturnTypes)
intellisense: NSDocumentAgent.UndoCheckoutDocument
keywords: NSDocumentAgent, UndoCheckoutDocument
so.topic: reference
---

Undo (abandon) a checkout

**Parameters:**
 - **documentId** SuperOffice document ID
 - **allowedReturnTypes** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.<br/>An empty array implies that the client places no restriction on possible return action requests.

**Returns:** NSReturnInfo

```crmscript
NSDocumentAgent agent;
Integer documentId;
String[] allowedReturnTypes;
NSReturnInfo res = agent.UndoCheckoutDocument(documentId, allowedReturnTypes);
```

