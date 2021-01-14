---
title: Bool checkTableRights(String tableRight)
path: /EJScript/Classes/Company/member functions/Bool checkTableRights(String tableRight)
intellisense: 1
classref: 1
sortOrder: 158
keywords: checkTableRights(String)
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


