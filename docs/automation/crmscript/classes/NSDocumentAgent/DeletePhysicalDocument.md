---
title: crmscript_ref_NSDocumentAgent_DeletePhysicalDocument_Integer_p_0_String__p_1
description: NSDocumentAgent.DeletePhysicalDocument(Integer p_0, String[] p_1)
intellisense: NSDocumentAgent.DeletePhysicalDocument
sortOrder: 2511
keywords: DeletePhysicalDocument(Integer,String[])
so.topic: reference
---


Delete the document contents



* **documentId:** document primary key
* **allowedReturnType:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing. Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.\<br/>An empty array implies that the client places no restriction on possible return action requests
* **Returns:** Delete status - did removal succeed or not


