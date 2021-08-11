---
uid: crmscript_ref_NSEMailAgent_LatestItemIdByFolder
title: Integer LatestItemIdByFolder(Integer folderId)
intellisense: NSEMailAgent.LatestItemIdByFolder
keywords: NSEMailAgent, LatestItemIdByFolder
so.topic: reference
---

# Integer LatestItemIdByFolder(Integer folderId)

Returns the latest id of the mail item by folder

**Parameters:**
 - **folderId** The folderId for the folder to check for the latest mail id

**Returns:** Integer

```crmscript
NSEMailAgent agent;
Integer folderId;
Integer res = agent.LatestItemIdByFolder(folderId);
```

