---
uid: crmscript_ref_Company_load_Integer_id
title: Company.load(Integer id)
intellisense: Company.load
sortOrder: 160
keywords: load(Integer)
so.topic: reference
---

# Company.load(Integer id)

Load object with values from company with given id.

## Parameters

 - id of the company

Returns a boolean of the load result, true if successfully loaded.

## Example

    Company c;
    
    Bool b = c.load(3);
    print(b.toString());

