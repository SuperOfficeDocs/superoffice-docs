---
title: Bool checkFieldRights(String field, String fieldRight)
path: /EJScript/Classes/Company/member functions/Bool checkFieldRights(String field, String fieldRight)
intellisense: 1
classref: 1
sortOrder: 157
keywords: checkFieldRights(String,String)
---

Use this function to see if the current user has access to the field.

fieldRight might be:


 - read
 - write




###Example code:###


    Company c;
    
    c.load(3);
    Bool b = c.checkFieldRights("contact", "read");
    print(b.toString());


