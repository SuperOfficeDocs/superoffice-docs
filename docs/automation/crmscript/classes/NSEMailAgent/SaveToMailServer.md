---
title: crmscript_ref_NSEMailAgent_SaveToMailServer
description: EMailEntity SaveToMailServer(EMailEntity email)
intellisense: NSEMailAgent.SaveToMailServer
keywords: NSEMailAgent,SaveToMailServer
so.topic: reference
---

Save the passed e-mail back to the mail server

**Parameters:**
 - **email** The e-mail to save

**Returns:** The updated saved entity

```crmscript
NSEMailAgent agent;
EMailEntity email;
EMailEntity res = agent.SaveToMailServer(email);
```

