---
title: crmscript_ref_NSQuoteAgent_GetOrderConfirmation_Integer_p_0_Integer_p_1
description: NSQuoteAgent.GetOrderConfirmation(Integer p_0, Integer p_1)
intellisense: NSQuoteAgent.GetOrderConfirmation
keywords: GetOrderConfirmation(Integer,Integer)
so.topic: reference
---


Get a base64-encoded data stream that is just the order confirmation document, for the given quote version; no permanent document is created or stored anywhere; the result is a PDF



* **quoteVersionId:** VersionId of the quote to be sent; the status of the version will not be changed by calling this method
* **confirmationTemplateId:** Id of the template for the order confirmation lines document
* **Returns:** Base64-encoded binary data, that is in fact a PDF document that should be shown to the user


