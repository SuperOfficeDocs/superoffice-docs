---
title: Bool load(Integer p0)
path: /EJScript/Classes/EabEntry/Member functions/Bool load(Integer p_0)
intellisense: 1
classref: 1
sortOrder: 274
keywords: load(Integer)
---

Load an entry from the address book with the specified id. Returns true if load var successful, false if not.



###Parameter:###


 - p0: id of the entry to load.




###Example code:###


    EabEntry eab;
    
    Bool b = eab.load(15);
    print(b.toString());


