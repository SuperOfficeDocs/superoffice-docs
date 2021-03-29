---
title: crmscript_ref_NSEMailAgent_GetEMailFromId_NSEMailConnectionInfo_p_0_Integer_p_1_Bool_p_2_Integer_p_3_Bool_p_4
description: NSEMailAgent.GetEMailFromId(NSEMailConnectionInfo p_0, Integer p_1, Bool p_2, Integer p_3, Bool p_4)
intellisense: NSEMailAgent.GetEMailFromId
sortOrder: 2821
keywords: GetEMailFromId(NSEMailConnectionInfo,Integer,Bool,Integer,Bool)
so.topic: reference
---


Get en e-mail based on its unique id



* **connectionInfo:** All information needed to connect to the mailserver
* **messageServerId:** Unique ID for the e-mail to retrieve
* **lookupAddresses:** If true try to look up e-mail addresses in from/to/cc/bcc fields against superoffice contacts
* **flags:** Any flags to apply to the fetched item. Ex: Seen/Answered
* **includeAttachments:** Should we retrieve attachments embedded in the e-mail from the server
* **Returns:** The e-mail


