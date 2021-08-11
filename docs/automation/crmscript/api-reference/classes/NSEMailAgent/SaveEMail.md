---
uid: crmscript_ref_NSEMailAgent_SaveEMail
title: NSEMailEntity SaveEMail(NSEMailConnectionInfo connectionInfo, NSEMailEntity email)
intellisense: NSEMailAgent.SaveEMail
keywords: NSEMailAgent, SaveEMail
so.topic: reference
---

# NSEMailEntity SaveEMail(NSEMailConnectionInfo connectionInfo, NSEMailEntity email)

Save the passed e-mail back to the server

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **email** The e-mail to save

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo connectionInfo;
NSEMailEntity email;
NSEMailEntity res = agent.SaveEMail(connectionInfo, email);
```

