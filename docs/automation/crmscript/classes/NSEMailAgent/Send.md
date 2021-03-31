---
title: crmscript_ref_NSEMailAgent_Send
description: EMailEntityArray Send(EMailEntityArray emails)
intellisense: NSEMailAgent.Send
keywords: NSEMailAgent,Send
so.topic: reference
---

Send the provided e-mails

**Parameters:**
 - **emails** The e-mails to send

**Returns:** The sent e-mails (updated with message id etc.)

```crmscript
NSEMailAgent agent;
EMailEntityArray emails;
EMailEntityArray res = agent.Send(emails);
```

