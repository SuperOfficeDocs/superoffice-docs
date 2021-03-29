---
title: crmscript_ref_ExtraTable_load_Integer_id
description: ExtraTable.load(Integer id)
intellisense: ExtraTable.load
sortOrder: 318
keywords: load(Integer)
so.topic: reference
---

Loads the extra table entry with the given id



###Parameter:###


 - id: Id of the extra table entry you want to load.


Returns true if the entry was found and loaded.



###Example code:###


    ExtraTable ex;
    
    Bool b = ex.load(2);
    print(b.toString());


