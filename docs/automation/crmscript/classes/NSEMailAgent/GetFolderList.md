---
title: String[] GetFolderList(NSEMailConnectionInfo connectionInfo, Bool includeItemCount)
path: /EJScript/Classes/NSEMailAgent/Member functions/String[] GetFolderList(NSEMailConnectionInfo p_0, Bool p_1)
intellisense: 1
classref: 1
sortOrder: 2853
keywords: GetFolderList(NSEMailConnectionInfo,Bool)
---


Retrieve all folders for the mail account. String is separated in sections by the paragraph character.  First section contains the folder delimeter char. Next is folder name. Additional sections may be unread and total items.



* **connectionInfo:** All information needed to connect to the mailserver
* **includeItemCount:** If true, unread and total items are added to the foldername separated by a comma
* **Returns:** List of available folders as a string array


