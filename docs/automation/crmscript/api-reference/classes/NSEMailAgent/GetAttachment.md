---
uid: crmscript_ref_NSEMailAgent_GetAttachment
title: NSEMailAttachment GetAttachment(NSEMailConnectionInfo connectionInfo, Integer messageServerId, String attachmentId)
intellisense: NSEMailAgent.GetAttachment
keywords: NSEMailAgent, GetAttachment
so.topic: reference
---

# NSEMailAttachment GetAttachment(NSEMailConnectionInfo connectionInfo, Integer messageServerId, String attachmentId)

Retrieve an attachment from an e-mail

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **messageServerId** Unique ID for the e-mail to retrieve the attachment from
 - **attachmentId** Id of the attachment in the e-mail

**Returns:** NSEMailAttachment

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo connectionInfo;
Integer messageServerId;
String attachmentId;
NSEMailAttachment res = agent.GetAttachment(connectionInfo, messageServerId, attachmentId);
```

