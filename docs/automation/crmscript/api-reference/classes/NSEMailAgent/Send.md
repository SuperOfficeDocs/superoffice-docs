---
uid: crmscript_ref_NSEMailAgent_Send
title: EMailEntity[] Send(EMailEntity[] emails)
intellisense: NSEMailAgent.Send
keywords: NSEMailAgent, Send
so.topic: reference
---

Send the provided e-mails

**Parameters:**
 - **emails** The e-mails to send

**Returns:** The sent e-mails (updated with message id etc.)

```crmscript
NSEMailAgent agent;
EMailEntity[] emails;
EMailEntity[] res = agent.Send(emails);
```

