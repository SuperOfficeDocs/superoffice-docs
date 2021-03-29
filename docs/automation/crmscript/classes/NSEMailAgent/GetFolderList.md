---
title: crmscript_ref_NSEMailAgent_GetFolderList_NSEMailConnectionInfo_p_0_Bool_p_1
description: NSEMailAgent.GetFolderList(NSEMailConnectionInfo p_0, Bool p_1)
intellisense: NSEMailAgent.GetFolderList
sortOrder: 2853
keywords: GetFolderList(NSEMailConnectionInfo,Bool)
so.topic: reference
---


Retrieve all folders for the mail account. String is separated in sections by the paragraph character.  First section contains the folder delimeter char. Next is folder name. Additional sections may be unread and total items.



* **connectionInfo:** All information needed to connect to the mailserver
* **includeItemCount:** If true, unread and total items are added to the foldername separated by a comma
* **Returns:** List of available folders as a string array


