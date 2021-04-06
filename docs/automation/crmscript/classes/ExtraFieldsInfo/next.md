---
uid: crmscript_ref_ExtraFieldsInfo_next
title: ExtraFieldsInfo.next()
intellisense: ExtraFieldsInfo.next
sortOrder: 315
keywords: next()
so.topic: reference
---

This function moves to the next field in the result.



###A common usage is in the increment section in a for loop:###


    ExtraFieldsInfo efi;
    
    for (efi.getTicketChildrenFields(); !efi.eof(); efi.next())
    {
      // do something with information from efi
    }


