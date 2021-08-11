---
uid: crmscript_ref_NSEMailAgent_CreateEMailFromMimeMessage
title: NSEMailEntity CreateEMailFromMimeMessage(String mimeMessage)
intellisense: NSEMailAgent.CreateEMailFromMimeMessage
keywords: NSEMailAgent, CreateEMailFromMimeMessage
so.topic: reference
---

# NSEMailEntity CreateEMailFromMimeMessage(String mimeMessage)

Get an e-mail based on the provided MIME-message

**Parameters:**
 - **mimeMessage** string representing a MIME-formatted message

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
String mimeMessage;
NSEMailEntity res = agent.CreateEMailFromMimeMessage(mimeMessage);
```

