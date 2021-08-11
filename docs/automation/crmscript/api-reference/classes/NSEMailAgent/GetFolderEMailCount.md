---
uid: crmscript_ref_NSEMailAgent_GetFolderEMailCount
title: Integer GetFolderEMailCount(NSEMailConnectionInfo connectionInfo, Bool onlyUnread)
intellisense: NSEMailAgent.GetFolderEMailCount
keywords: NSEMailAgent, GetFolderEMailCount
so.topic: reference
---

# Integer GetFolderEMailCount(NSEMailConnectionInfo connectionInfo, Bool onlyUnread)

Retrieve total/unread mail items in current folder

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **onlyUnread** If true, only unread items are counted

**Returns:** Integer

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo connectionInfo;
Bool onlyUnread;
Integer res = agent.GetFolderEMailCount(connectionInfo, onlyUnread);
```

