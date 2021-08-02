---
uid: crmscript_ref_NSEMailAgent_AuthenticateIncoming
title: Bool AuthenticateIncoming(NSEMailConnectionInfo connectionInfo)
intellisense: NSEMailAgent.AuthenticateIncoming
keywords: NSEMailAgent, AuthenticateIncoming
so.topic: reference
---

Authenticate against a mail-server to retrieve e-mails from

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver

**Returns:** Bool

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo connectionInfo;
Bool res = agent.AuthenticateIncoming(connectionInfo);
```

