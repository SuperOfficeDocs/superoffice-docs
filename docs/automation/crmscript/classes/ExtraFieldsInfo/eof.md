---
title: Bool eof()
path: /EJScript/Classes/ExtraFieldsInfo/Member functions/Bool eof()
intellisense: 1
classref: 1
sortOrder: 303
keywords: eof()
---

This function checks if there are no more fields in the result.



###A common usage is in the condition section in a for loop:###


    ExtraFieldsInfo efi;
    
    for (efi.getTicketChildrenFields(); !efi.eof(); efi.next())
    {
      // do something with information from efi
    }


