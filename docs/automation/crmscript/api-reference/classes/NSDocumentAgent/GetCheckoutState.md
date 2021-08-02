---
uid: crmscript_ref_NSDocumentAgent_GetCheckoutState
title: NSCheckoutInfo GetCheckoutState(Integer documentId)
intellisense: NSDocumentAgent.GetCheckoutState
keywords: NSDocumentAgent, GetCheckoutState
so.topic: reference
---

Get the current checkout state for a document, relative to the user perforing the call.

**Parameters:**
 - **documentId** SuperOffice document ID

**Returns:** NSCheckoutInfo

```crmscript
NSDocumentAgent agent;
Integer documentId;
NSCheckoutInfo res = agent.GetCheckoutState(documentId);
```

