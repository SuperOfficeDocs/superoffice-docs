---
title: crmscript_ref_NSDocumentAgent_UndoCheckoutDocument_Integer_p_0_String__p_1
description: NSDocumentAgent.UndoCheckoutDocument(Integer p_0, String[] p_1)
intellisense: NSDocumentAgent.UndoCheckoutDocument
sortOrder: 2513
keywords: UndoCheckoutDocument(Integer,String[])
so.topic: reference
---


Undo (abandon) a checkout



* **documentId:** SuperOffice document ID
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.\<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.\<br/>An empty array implies that the client places no restriction on possible return action requests.
* **Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.


