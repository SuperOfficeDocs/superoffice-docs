---
title: crmscript_ref_NSEMailAgent_SaveEMail
description: EMailEntity SaveEMail(EMailConnectionInfo connectionInfo, EMailEntity email)
intellisense: NSEMailAgent.SaveEMail
keywords: NSEMailAgent,SaveEMail
so.topic: reference
---

Save the passed e-mail back to the server

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **email** The e-mail to save

**Returns:** The updated saved entity

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
EMailEntity email;
EMailEntity res = agent.SaveEMail(connectionInfo, email);
```

