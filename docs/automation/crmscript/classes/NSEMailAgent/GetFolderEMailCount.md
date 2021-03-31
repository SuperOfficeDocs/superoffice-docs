---
title: crmscript_ref_NSEMailAgent_GetFolderEMailCount
description: Integer GetFolderEMailCount(EMailConnectionInfo connectionInfo, Bool onlyUnread)
intellisense: NSEMailAgent.GetFolderEMailCount
keywords: NSEMailAgent,GetFolderEMailCount
so.topic: reference
---

Retrieve total/unread mail items in current folder

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **onlyUnread** If true, only unread items are counted

**Returns:** Number of mail items

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
Bool onlyUnread;
Integer res = agent.GetFolderEMailCount(connectionInfo, onlyUnread);
```

