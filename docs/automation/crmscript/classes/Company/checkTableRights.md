---
uid: crmscript_ref_Company_checkTableRights_String_tableRight
title: Company.checkTableRights(String tableRight)
intellisense: Company.checkTableRights
sortOrder: 158
keywords: checkTableRights(String)
so.topic: reference
---

Use this function to see if the current user has access to this company.

tableRight might be:


- select
- update
- insert




###Example code:###


    Company c;
    
    c.load(3);
    Bool b = c.checkTableRights("select");
    print(b.toString());


