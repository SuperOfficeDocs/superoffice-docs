---
title: NSCommandInfo[] GetDocumentCommands(Integer documentId, String[] allowedReturnTypes)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSCommandInfo[] GetDocumentCommands(Integer p_0, String[] p_1)
intellisense: 1
classref: 1
sortOrder: 2469
keywords: GetDocumentCommands(Integer,String[])
---


Get a list of custom commands valid for the specific document at this time. This information should not be cached by clients, as it may change between documents and over time.



* **documentId:** SuperOffice document ID
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.\<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.\<br/>An empty array implies that the client places no restriction on possible return action requests.\<br/>In this context the parameter is used to filter the returned command list, so that commands that require return actions not supported, will not be included by the document plugin.
* **Returns:** Array of command information items. The command list is constrained by the allowedReturnTypes parameter.


