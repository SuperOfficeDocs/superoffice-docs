---
title: crmscript_ref_NSDocumentAgent_CheckoutDocument_Integer_p_0_String__p_1
description: NSDocumentAgent.CheckoutDocument(Integer p_0, String[] p_1)
intellisense: NSDocumentAgent.CheckoutDocument
sortOrder: 2510
keywords: CheckoutDocument(Integer,String[])
so.topic: reference
---


Check out a document for editing by the current user.



* **documentId:** SuperOffice document ID
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.\<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.\<br/>An empty array implies that the client places no restriction on possible return action requests.
* **Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.


