---
title: NSReturnInfo ExecuteDocumentCommand(Integer documentId, String versionId, String[] allowedReturnTypes, String command, String[] additionalData)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSReturnInfo ExecuteDocumentCommand(Integer p_0, String p_1, String[] p_2, String p_3, String[] p_4)
intellisense: 1
classref: 1
sortOrder: 2512
keywords: ExecuteDocumentCommand(Integer,String,String[],String,String[])
---


Execute a custom command on a particular document, optionally a particular version



* **documentId:** SuperOffice document ID
* **versionId:** Version ID if applicable/desired; a blank value implies "latest" version and is always acceptable.
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.\<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.\<br/>An empty array implies that the client places no restriction on possible return action requests.
* **command:** Command name, generally matching one of those returned from the GetDocumentCommands service. However, it is legal for document plugins to support commands that are not declared through GetDocumentCommands, for instance if a custom GUI needs to access plugin functionality.
* **additionalData:** Any additional data that the document command needs. This parameter can be used as a tunnel between a custom-programmed GUI and its plugin.\<br/>It is suggested that the format is name=value, with one such pair per array item.
* **Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.


