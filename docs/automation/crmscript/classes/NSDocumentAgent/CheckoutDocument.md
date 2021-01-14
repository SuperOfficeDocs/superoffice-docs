---
title: NSReturnInfo CheckoutDocument(Integer documentId, String[] allowedReturnTypes)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSReturnInfo CheckoutDocument(Integer p_0, String[] p_1)
intellisense: 1
classref: 1
sortOrder: 2510
keywords: CheckoutDocument(Integer,String[])
---


Check out a document for editing by the current user.



* **documentId:** SuperOffice document ID
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.\<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.\<br/>An empty array implies that the client places no restriction on possible return action requests.
* **Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.


