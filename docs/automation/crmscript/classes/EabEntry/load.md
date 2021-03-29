---
title: crmscript_ref_EabEntry_load_Integer_p_0
description: EabEntry.load(Integer p_0)
intellisense: EabEntry.load
sortOrder: 274
keywords: load(Integer)
so.topic: reference
---

Load an entry from the address book with the specified id. Returns true if load var successful, false if not.



###Parameter:###


 - p0: id of the entry to load.




###Example code:###


    EabEntry eab;
    
    Bool b = eab.load(15);
    print(b.toString());


