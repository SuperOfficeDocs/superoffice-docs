---
title: crmscript_ref_NSEMailAgent_RefreshFolderForAssociate
description: String RefreshFolderForAssociate(StringArray folders)
intellisense: NSEMailAgent.RefreshFolderForAssociate
keywords: NSEMailAgent,RefreshFolderForAssociate
so.topic: reference
---

Get all emails in folder(s) from current associate

**Parameters:**
 - **folders** List of folder names to refresh

**Returns:** JSON serialized string containing array of data about each folder

```crmscript
NSEMailAgent agent;
StringArray folders;
String res = agent.RefreshFolderForAssociate(folders);
```

