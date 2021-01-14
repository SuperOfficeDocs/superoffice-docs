---
title: Bool checkFieldRights(String field, String fieldRight)
path: /EJScript/Classes/Customer/Member functions/Bool checkFieldRights(String field, String fieldRight)
intellisense: 1
classref: 1
sortOrder: 172
keywords: checkFieldRights(String,String)
---

Use this function to see if the current user has access to the field.

fieldRight might be:


 - read
 - write




###Example code:###


    Customer c;
    
    c.load(3);
    Bool b = c.checkFieldRights("person","read");
    print(b.toString());


