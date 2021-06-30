---
uid: crmscript_ref_NSEMailAgent_GetFolderInfo
title: EMailFolder[] GetFolderInfo(EMailConnectionInfo connectionInfo, String[] folders)
intellisense: NSEMailAgent.GetFolderInfo
keywords: NSEMailAgent, GetFolderInfo
so.topic: reference
---

Retrieve information about folders.  If folders parameter is not specified(null), information about all subscribed folders will be returned.

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **folders** Folders to get information about.

**Returns:** Folder information

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
String[] folders;
EMailFolder[] res = agent.GetFolderInfo(connectionInfo, folders);
```

