---
title: Integer RefreshFolder(NSEMailConnectionInfo connectionInfo, String[] folders)
path: /EJScript/Classes/NSEMailAgent/Member functions/Integer RefreshFolder(NSEMailConnectionInfo p_0, String[] p_1)
intellisense: 1
classref: 1
sortOrder: 2791
keywords: RefreshFolder(NSEMailConnectionInfo,String[])
---


Refresh the given folders - i.e., fetch data from the mail server and update the in-database cache. This may happen synchronously or as a batch task, the return value will be 0 if the processing was synchronous, or the batch task id if a batch task is used.



* **connectionInfo:** Email connection info credentials
* **folders:** List of folder names to refresh
* **Returns:** Batch task id, or 0 if the processing was synchronous


