---
title: crmscript_ref_NSEMailAgent_LatestItemIdByFolder
description: Integer LatestItemIdByFolder(Integer folderId)
intellisense: NSEMailAgent.LatestItemIdByFolder
keywords: NSEMailAgent,LatestItemIdByFolder
so.topic: reference
---

Returns the latest id of the mail item by folder

**Parameters:**
 - **folderId** The folderId for the folder to check for the latest mail id

**Returns:** Mail Item id

```crmscript
NSEMailAgent agent;
Integer folderId;
Integer res = agent.LatestItemIdByFolder(folderId);
```

