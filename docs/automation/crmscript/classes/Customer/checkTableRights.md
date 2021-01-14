---
title: Bool checkTableRights(String tableRight)
path: /EJScript/Classes/Customer/Member functions/Bool checkTableRights(String tableRight)
intellisense: 1
classref: 1
sortOrder: 173
keywords: checkTableRights(String)
---

Use this function to see if the current user has access to this customer.

tableRight might be:


- select
- update
- insert




###Example code:###


    Customer c;
    
    c.load(3);
    Bool b = c.checkTableRights("select");
    print(b.toString());


