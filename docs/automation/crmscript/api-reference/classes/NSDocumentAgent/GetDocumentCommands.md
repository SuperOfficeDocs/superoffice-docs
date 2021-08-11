---
uid: crmscript_ref_NSDocumentAgent_GetDocumentCommands
title: NSCommandInfo[] GetDocumentCommands(Integer documentId, String[] allowedReturnTypes)
intellisense: NSDocumentAgent.GetDocumentCommands
keywords: NSDocumentAgent, GetDocumentCommands
so.topic: reference
---

# NSCommandInfo[] GetDocumentCommands(Integer documentId, String[] allowedReturnTypes)

Get a list of custom commands valid for the specific document at this time. This information should not be cached by clients, as it may change between documents and over time.

**Parameters:**
 - **documentId** SuperOffice document ID
 - **allowedReturnTypes** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.<br/>An empty array implies that the client places no restriction on possible return action requests.<br/>In this context the parameter is used to filter the returned command list, so that commands that require return actions not supported, will not be included by the document plugin.

**Returns:** NSCommandInfo[]

```crmscript
NSDocumentAgent agent;
Integer documentId;
String[] allowedReturnTypes;
NSCommandInfo[] res = agent.GetDocumentCommands(documentId, allowedReturnTypes);
```

