---
title: crmscript_ref_NSEMailAgent_CreateEMailFromMimeMessage
description: EMailEntity CreateEMailFromMimeMessage(String mimeMessage)
intellisense: NSEMailAgent.CreateEMailFromMimeMessage
keywords: NSEMailAgent,CreateEMailFromMimeMessage
so.topic: reference
---

Get an e-mail based on the provided MIME-message

**Parameters:**
 - **mimeMessage** string representing a MIME-formatted message

**Returns:** The e-mail

```crmscript
NSEMailAgent agent;
String mimeMessage;
EMailEntity res = agent.CreateEMailFromMimeMessage(mimeMessage);
```

