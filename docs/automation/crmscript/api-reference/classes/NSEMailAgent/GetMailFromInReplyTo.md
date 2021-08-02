---
uid: crmscript_ref_NSEMailAgent_GetMailFromInReplyTo
title: NSEMailEntity GetMailFromInReplyTo(String messageId)
intellisense: NSEMailAgent.GetMailFromInReplyTo
keywords: NSEMailAgent, GetMailFromInReplyTo
so.topic: reference
---

Get email from db based on In-Reply-To Message Id

**Parameters:**
 - **messageId** The message id

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
String messageId;
NSEMailEntity res = agent.GetMailFromInReplyTo(messageId);
```

