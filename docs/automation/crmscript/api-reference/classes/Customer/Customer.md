---
uid: crmscript_ref_Customer
title: Customer
intellisense: Void.Customer
sortOrder: 170
so.topic: reference
---

# Customer

Class for representing a customer.

## Example

    Customer c;
    
    c.load(2); // Loads customer with id = 2
    print(c.getValue("email")); // Returns a list of all emails
    c.setValue("firstname", "Bob");
    c.save();
