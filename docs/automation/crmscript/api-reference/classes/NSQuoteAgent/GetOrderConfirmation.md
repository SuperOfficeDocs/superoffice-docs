---
uid: crmscript_ref_NSQuoteAgent_GetOrderConfirmation
title: String GetOrderConfirmation(Integer quoteVersionId, Integer confirmationTemplateId)
intellisense: NSQuoteAgent.GetOrderConfirmation
keywords: NSQuoteAgent, GetOrderConfirmation
so.topic: reference
---

# String GetOrderConfirmation(Integer quoteVersionId, Integer confirmationTemplateId)

Get a base64-encoded data stream that is just the order confirmation document, for the given quote version; no permanent document is created or stored anywhere; the result is a PDF

**Parameters:**
 - **quoteVersionId** VersionId of the quote to be sent; the status of the version will not be changed by calling this method
 - **confirmationTemplateId** Id of the template for the order confirmation lines document

**Returns:** String

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
Integer confirmationTemplateId;
String res = agent.GetOrderConfirmation(quoteVersionId, confirmationTemplateId);
```

