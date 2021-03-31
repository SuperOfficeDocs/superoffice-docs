---
uid: crmscript_ref_NSEMailAgent_AuthenticateIncoming
title: Bool AuthenticateIncoming(EMailConnectionInfo connectionInfo)
intellisense: NSEMailAgent.AuthenticateIncoming
keywords: NSEMailAgent, AuthenticateIncoming
so.topic: reference
---

Authenticate against a mail-server to retrieve e-mails from

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver

**Returns:** True if authentication was succcesfull

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
Bool res = agent.AuthenticateIncoming(connectionInfo);
```

