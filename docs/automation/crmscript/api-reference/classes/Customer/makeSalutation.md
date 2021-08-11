---
uid: crmscript_ref_Customer_makeSalutation
title: Customer.makeSalutation()
intellisense: Customer.makeSalutation
sortOrder: 185
keywords: makeSalutation()
so.topic: reference
---

# Customer.makeSalutation()

Create a salutation greeting the customer. Can be used in the beginning of a document or email.

Returns salutation string.

## Example

    Customer c;
    
    c.load(3);
    Bool b = c.checkTableRights("select");
    print(b.toString());
    
    c.setValue("name", "Test");
    c.setValue("salutation", "Welcome to SuperOffice");
    
    c.makeSalutation();

