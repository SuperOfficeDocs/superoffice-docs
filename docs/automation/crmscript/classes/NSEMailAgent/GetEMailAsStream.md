---
title: crmscript_ref_NSEMailAgent_GetEMailAsStream
description: Stream GetEMailAsStream(EMailConnectionInfo connectionInfo, Integer messageServerId, Bool stripAttachments)
intellisense: NSEMailAgent.GetEMailAsStream
keywords: NSEMailAgent,GetEMailAsStream
so.topic: reference
---

Retrieve an e-mail optionally stripping attachments as a stream

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **messageServerId** Unique ID for the e-mail to retrieve
 - **stripAttachments** If true, do not include attachments in stream

**Returns:** The attachment as a stream

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
Integer messageServerId;
Bool stripAttachments;
Stream res = agent.GetEMailAsStream(connectionInfo, messageServerId, stripAttachments);
```

