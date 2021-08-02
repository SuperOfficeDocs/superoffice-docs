---
uid: crmscript_ref_NSEMailAgent_RefreshFolderForAssociate
title: String RefreshFolderForAssociate(String[] folders)
intellisense: NSEMailAgent.RefreshFolderForAssociate
keywords: NSEMailAgent, RefreshFolderForAssociate
so.topic: reference
---

Get all emails in folder(s) from current associate

**Parameters:**
 - **folders** List of folder names to refresh

**Returns:** String

```crmscript
NSEMailAgent agent;
String[] folders;
String res = agent.RefreshFolderForAssociate(folders);
```

