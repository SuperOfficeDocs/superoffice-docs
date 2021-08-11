---
uid: crmscript_ref_NSEMailAgent_GetMailFromMessageId
title: NSEMailEntity GetMailFromMessageId(String messageId)
intellisense: NSEMailAgent.GetMailFromMessageId
keywords: NSEMailAgent, GetMailFromMessageId
so.topic: reference
---

# NSEMailEntity GetMailFromMessageId(String messageId)

Get email from db based on Message Id

**Parameters:**
 - **messageId** The message id

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
String messageId;
NSEMailEntity res = agent.GetMailFromMessageId(messageId);
```

