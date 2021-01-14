---
title: Void next()
path: /EJScript/Classes/ExtraFieldsInfo/Member functions/Void next()
intellisense: 1
classref: 1
sortOrder: 315
keywords: next()
---

This function moves to the next field in the result.



###A common usage is in the increment section in a for loop:###


    ExtraFieldsInfo efi;
    
    for (efi.getTicketChildrenFields(); !efi.eof(); efi.next())
    {
      // do something with information from efi
    }


