---
title: String GetOrderConfirmation(Integer quoteVersionId, Integer confirmationTemplateId)
path: /EJScript/Classes/NSQuoteAgent/Member functions/String GetOrderConfirmation(Integer p_0, Integer p_1)
intellisense: 1
classref: 1
keywords: GetOrderConfirmation(Integer,Integer)
---


Get a base64-encoded data stream that is just the order confirmation document, for the given quote version; no permanent document is created or stored anywhere; the result is a PDF



* **quoteVersionId:** VersionId of the quote to be sent; the status of the version will not be changed by calling this method
* **confirmationTemplateId:** Id of the template for the order confirmation lines document
* **Returns:** Base64-encoded binary data, that is in fact a PDF document that should be shown to the user


