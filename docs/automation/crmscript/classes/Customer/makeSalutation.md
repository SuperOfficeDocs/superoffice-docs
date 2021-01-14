---
title: String makeSalutation()
path: /EJScript/Classes/Customer/Member functions/String makeSalutation()
intellisense: 1
classref: 1
sortOrder: 185
keywords: makeSalutation()
---

Create a salutation greeting the customer. Can be used in the beginning of a document or email.

Returns salutation string.



###Example code:###


    Customer c;
    
    c.load(3);
    Bool b = c.checkTableRights("select");
    print(b.toString());
    
    c.setValue("name", "Test");
    c.setValue("salutation", "Welcome to SuperOffice");
    
    c.makeSalutation();


