---
title: crmscript_ref_ExtraTable_getValue_String_field
description: ExtraTable.getValue(String field)
intellisense: ExtraTable.getValue
sortOrder: 323
keywords: getValue(String)
so.topic: reference
---


This function returns the value of the given field for the currently loaded entry.




###Parameter:###


 - field: The name of the extra table field - e.g. "x\_myfield"




###Example code:###


    ExtraTable ex;
    
    Bool b = ex.load(2);
    print(b.toString());
    
    print(ex.getValue("x_table"));


