---
title: crmscript_ref_NSEMailAgent_GetMailFromInReplyTo
description: EMailEntity GetMailFromInReplyTo(String messageId)
intellisense: NSEMailAgent.GetMailFromInReplyTo
keywords: NSEMailAgent,GetMailFromInReplyTo
so.topic: reference
---

Get email from db based on In-Reply-To Message Id

**Parameters:**
 - **messageId** The message id

**Returns:** EMailEntity that is in reply to the provided messageId

```crmscript
NSEMailAgent agent;
String messageId;
EMailEntity res = agent.GetMailFromInReplyTo(messageId);
```

