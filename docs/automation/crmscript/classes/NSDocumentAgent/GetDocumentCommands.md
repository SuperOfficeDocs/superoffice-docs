---
title: crmscript_ref_NSDocumentAgent_GetDocumentCommands_Integer_p_0_String__p_1
description: NSDocumentAgent.GetDocumentCommands(Integer p_0, String[] p_1)
intellisense: NSDocumentAgent.GetDocumentCommands
sortOrder: 2469
keywords: GetDocumentCommands(Integer,String[])
so.topic: reference
---


Get a list of custom commands valid for the specific document at this time. This information should not be cached by clients, as it may change between documents and over time.



* **documentId:** SuperOffice document ID
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.\<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.\<br/>An empty array implies that the client places no restriction on possible return action requests.\<br/>In this context the parameter is used to filter the returned command list, so that commands that require return actions not supported, will not be included by the document plugin.
* **Returns:** Array of command information items. The command list is constrained by the allowedReturnTypes parameter.


