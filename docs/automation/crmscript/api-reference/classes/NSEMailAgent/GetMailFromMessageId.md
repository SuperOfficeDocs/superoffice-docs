---
uid: crmscript_ref_NSEMailAgent_GetMailFromMessageId
title: EMailEntity GetMailFromMessageId(String messageId)
intellisense: NSEMailAgent.GetMailFromMessageId
keywords: NSEMailAgent, GetMailFromMessageId
so.topic: reference
---

Get email from db based on Message Id

**Parameters:**
 - **messageId** The message id

**Returns:** EMailEntity with the provided message id

```crmscript
NSEMailAgent agent;
String messageId;
EMailEntity res = agent.GetMailFromMessageId(messageId);
```

