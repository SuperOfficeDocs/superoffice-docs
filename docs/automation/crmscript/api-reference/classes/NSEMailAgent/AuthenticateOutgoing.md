---
uid: crmscript_ref_NSEMailAgent_AuthenticateOutgoing
title: Bool AuthenticateOutgoing(NSEMailConnectionInfo connectionInfo)
intellisense: NSEMailAgent.AuthenticateOutgoing
keywords: NSEMailAgent, AuthenticateOutgoing
so.topic: reference
---

Authenticate against a mail server to send items with

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver

**Returns:** Bool

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo connectionInfo;
Bool res = agent.AuthenticateOutgoing(connectionInfo);
```

