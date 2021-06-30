---
uid: crmscript_ref_NSDocumentAgent_ExecuteDocumentCommand
title: ReturnInfo ExecuteDocumentCommand(Integer documentId, String versionId, String[] allowedReturnTypes, String command, String[] additionalData)
intellisense: NSDocumentAgent.ExecuteDocumentCommand
keywords: NSDocumentAgent, ExecuteDocumentCommand
so.topic: reference
---

Execute a custom command on a particular document, optionally a particular version

**Parameters:**
 - **documentId** SuperOffice document ID
 - **versionId** Version ID if applicable/desired; a blank value implies "latest" version and is always acceptable.
 - **allowedReturnTypes** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.<br/>An empty array implies that the client places no restriction on possible return action requests.
 - **command** Command name, generally matching one of those returned from the GetDocumentCommands service. However, it is legal for document plugins to support commands that are not declared through GetDocumentCommands, for instance if a custom GUI needs to access plugin functionality.
 - **additionalData** Any additional data that the document command needs. This parameter can be used as a tunnel between a custom-programmed GUI and its plugin.<br/>It is suggested that the format is name=value, with one such pair per array item.

**Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.

```crmscript
NSDocumentAgent agent;
Integer documentId;
String versionId;
String[] allowedReturnTypes;
String command;
String[] additionalData;
ReturnInfo res = agent.ExecuteDocumentCommand(documentId, versionId, allowedReturnTypes, command, additionalData);
```

