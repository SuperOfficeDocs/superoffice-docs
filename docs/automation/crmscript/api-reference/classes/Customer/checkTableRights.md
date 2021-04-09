---
uid: crmscript_ref_Customer_checkTableRights_String_tableRight
title: Customer.checkTableRights(String tableRight)
intellisense: Customer.checkTableRights
sortOrder: 173
keywords: checkTableRights(String)
so.topic: reference
---

Use this function to see if the current user has access to this customer.

tableRight might be:


- select
- update
- insert




## Example


    Customer c;
    
    c.load(3);
    Bool b = c.checkTableRights("select");
    print(b.toString());


