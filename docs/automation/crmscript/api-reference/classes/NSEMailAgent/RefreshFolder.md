---
uid: crmscript_ref_NSEMailAgent_RefreshFolder
title: Integer RefreshFolder(EMailConnectionInfo connectionInfo, String[] folders)
intellisense: NSEMailAgent.RefreshFolder
keywords: NSEMailAgent, RefreshFolder
so.topic: reference
---

Refresh the given folders - i.e., fetch data from the mail server and update the in-database cache. This may happen synchronously or as a batch task, the return value will be 0 if the processing was synchronous, or the batch task id if a batch task is used.

**Parameters:**
 - **connectionInfo** Email connection info credentials
 - **folders** List of folder names to refresh

**Returns:** Batch task id, or 0 if the processing was synchronous

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
String[] folders;
Integer res = agent.RefreshFolder(connectionInfo, folders);
```

