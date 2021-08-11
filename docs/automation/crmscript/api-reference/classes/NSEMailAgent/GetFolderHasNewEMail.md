---
uid: crmscript_ref_NSEMailAgent_GetFolderHasNewEMail
title: Bool GetFolderHasNewEMail(NSEMailConnectionInfo connectionInfo)
intellisense: NSEMailAgent.GetFolderHasNewEMail
keywords: NSEMailAgent, GetFolderHasNewEMail
so.topic: reference
---

# Bool GetFolderHasNewEMail(NSEMailConnectionInfo connectionInfo)

Check if folder has received new items since previous access.

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver

**Returns:** Bool

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo connectionInfo;
Bool res = agent.GetFolderHasNewEMail(connectionInfo);
```

