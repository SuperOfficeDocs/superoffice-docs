---
title: crmscript_ref_NSDocumentAgent_GetCheckoutState
description: CheckoutInfo GetCheckoutState(Integer documentId)
intellisense: NSDocumentAgent.GetCheckoutState
keywords: NSDocumentAgent,GetCheckoutState
so.topic: reference
---

Get the current checkout state for a document, relative to the user perforing the call.

**Parameters:**
 - **documentId** SuperOffice document ID

**Returns:** Current checkout state of the document

```crmscript
NSDocumentAgent agent;
Integer documentId;
CheckoutInfo res = agent.GetCheckoutState(documentId);
```

