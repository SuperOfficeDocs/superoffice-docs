---
title: NSReturnInfo CheckinDocument(Integer documentId, String[] allowedReturnTypes, String versionDescription, String[] versionExtraFields)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSReturnInfo CheckinDocument(Integer p_0, String[] p_1, String p_2, String[] p_3)
intellisense: 1
classref: 1
sortOrder: 2509
keywords: CheckinDocument(Integer,String[],String,String[])
---


Check in a currently checked-out document



* **documentId:** SuperOffice document Id
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.\<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.\<br/>An empty array implies that the client places no restriction on possible return action requests.
* **versionDescription:** Optional textual description related to this version of the document; may be blank, and is discarded if the document/plugin do not support versioning.
* **versionExtraFields:** Optional extra metadata related to the new version (as opposed to metadata related to the document as a whole). Discarded if the document/plugin do not support versioning.
* **Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.


