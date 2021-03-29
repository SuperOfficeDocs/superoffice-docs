---
title: crmscript_ref_Message_send_Vector_p_to_Vector_p_cc_Vector_p_bcc_Integer_p_categoryId
description: Message.send(Vector p_to, Vector p_cc, Vector p_bcc, Integer p_categoryId)
intellisense: Message.send
sortOrder: 542
keywords: send(Vector,Vector,Vector,Integer)
so.topic: reference
---

Sends an e-mail-version of the message to the main contacts on the parent ticket.
Merge with reply template int the settings of the submitted category id.



###Parameters:###


 - Vector To-recipient(s) in e-mail
 - Vector Cc-recipient(s) in e-mail
 - Vector Bcc-recipient(s) in e-mail
 - Integer The id of the category to check for reply template merge


Returns a bool of send result, true if successful.


