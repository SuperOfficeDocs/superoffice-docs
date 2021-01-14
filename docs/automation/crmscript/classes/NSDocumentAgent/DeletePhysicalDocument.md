---
title: NSReturnInfo DeletePhysicalDocument(Integer documentId, String[] allowedReturnType)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSReturnInfo DeletePhysicalDocument(Integer p_0, String[] p_1)
intellisense: 1
classref: 1
sortOrder: 2511
keywords: DeletePhysicalDocument(Integer,String[])
---


Delete the document contents



* **documentId:** document primary key
* **allowedReturnType:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing. Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.\<br/>An empty array implies that the client places no restriction on possible return action requests
* **Returns:** Delete status - did removal succeed or not


