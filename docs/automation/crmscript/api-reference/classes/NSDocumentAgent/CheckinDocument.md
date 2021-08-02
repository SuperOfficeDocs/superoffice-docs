---
uid: crmscript_ref_NSDocumentAgent_CheckinDocument
title: NSReturnInfo CheckinDocument(Integer documentId, String[] allowedReturnTypes, String versionDescription, String[] versionExtraFields)
intellisense: NSDocumentAgent.CheckinDocument
keywords: NSDocumentAgent, CheckinDocument
so.topic: reference
---

Check in a currently checked-out document

**Parameters:**
 - **documentId** SuperOffice document Id
 - **allowedReturnTypes** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.<br/>Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.<br/>An empty array implies that the client places no restriction on possible return action requests.
 - **versionDescription** Optional textual description related to this version of the document; may be blank, and is discarded if the document/plugin do not support versioning.
 - **versionExtraFields** Optional extra metadata related to the new version (as opposed to metadata related to the document as a whole). Discarded if the document/plugin do not support versioning.

**Returns:** NSReturnInfo

```crmscript
NSDocumentAgent agent;
Integer documentId;
String[] allowedReturnTypes;
String versionDescription;
String[] versionExtraFields;
NSReturnInfo res = agent.CheckinDocument(documentId, allowedReturnTypes, versionDescription, versionExtraFields);
```

