---
uid: crmscript_ref_EabEntry_load_Integer_p_0
title: EabEntry.load(Integer p_0)
intellisense: EabEntry.load
sortOrder: 274
keywords: load(Integer)
so.topic: reference
---

# EabEntry.load(Integer p_0)

Load an entry from the address book with the specified id. Returns true if load var successful, false if not.

## Parameters

 - p0: id of the entry to load.

## Example

    EabEntry eab;
    
    Bool b = eab.load(15);
    print(b.toString());

