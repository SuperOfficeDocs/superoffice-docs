---
title: crmscript_ref_NSEMailAgent_GetAttachment
description: EMailAttachment GetAttachment(EMailConnectionInfo connectionInfo, Integer messageServerId, String attachmentId)
intellisense: NSEMailAgent.GetAttachment
keywords: NSEMailAgent,GetAttachment
so.topic: reference
---

Retrieve an attachment from an e-mail

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **messageServerId** Unique ID for the e-mail to retrieve the attachment from
 - **attachmentId** Id of the attachment in the e-mail

**Returns:** The attachment

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
Integer messageServerId;
String attachmentId;
EMailAttachment res = agent.GetAttachment(connectionInfo, messageServerId, attachmentId);
```

