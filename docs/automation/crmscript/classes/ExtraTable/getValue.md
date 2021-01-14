---
title: String getValue(String field)
path: /EJScript/Classes/ExtraTable/Member functions/String getValue(String field)
intellisense: 1
classref: 1
sortOrder: 323
keywords: getValue(String)
---


This function returns the value of the given field for the currently loaded entry.




###Parameter:###


 - field: The name of the extra table field - e.g. "x\_myfield"




###Example code:###


    ExtraTable ex;
    
    Bool b = ex.load(2);
    print(b.toString());
    
    print(ex.getValue("x_table"));


