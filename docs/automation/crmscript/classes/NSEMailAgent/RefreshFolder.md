---
title: crmscript_ref_NSEMailAgent_RefreshFolder_NSEMailConnectionInfo_p_0_String__p_1
description: NSEMailAgent.RefreshFolder(NSEMailConnectionInfo p_0, String[] p_1)
intellisense: NSEMailAgent.RefreshFolder
sortOrder: 2791
keywords: RefreshFolder(NSEMailConnectionInfo,String[])
so.topic: reference
---


Refresh the given folders - i.e., fetch data from the mail server and update the in-database cache. This may happen synchronously or as a batch task, the return value will be 0 if the processing was synchronous, or the batch task id if a batch task is used.



* **connectionInfo:** Email connection info credentials
* **folders:** List of folder names to refresh
* **Returns:** Batch task id, or 0 if the processing was synchronous


