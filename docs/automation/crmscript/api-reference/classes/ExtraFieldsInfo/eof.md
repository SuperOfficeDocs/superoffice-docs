---
uid: crmscript_ref_ExtraFieldsInfo_eof
title: ExtraFieldsInfo.eof()
intellisense: ExtraFieldsInfo.eof
sortOrder: 303
keywords: eof()
so.topic: reference
---

This function checks if there are no more fields in the result.

## Usage

A common usage is in the condition section in a for-loop:

    ExtraFieldsInfo efi;
    
    for (efi.getTicketChildrenFields(); !efi.eof(); efi.next())
    {
      // do something with information from efi
    }


