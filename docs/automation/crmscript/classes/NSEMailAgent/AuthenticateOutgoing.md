---
title: crmscript_ref_NSEMailAgent_AuthenticateOutgoing
description: Bool AuthenticateOutgoing(EMailConnectionInfo connectionInfo)
intellisense: NSEMailAgent.AuthenticateOutgoing
keywords: NSEMailAgent,AuthenticateOutgoing
so.topic: reference
---

Authenticate against a mail server to send items with

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver

**Returns:** True if authentication was succcesfull

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
Bool res = agent.AuthenticateOutgoing(connectionInfo);
```

