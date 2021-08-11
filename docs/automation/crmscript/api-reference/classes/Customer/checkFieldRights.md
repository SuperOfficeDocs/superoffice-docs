---
uid: crmscript_ref_Customer_checkFieldRights_String_field_String_fieldRight
title: Customer.checkFieldRights(String field, String fieldRight)
intellisense: Customer.checkFieldRights
sortOrder: 172
keywords: checkFieldRights(String,String)
so.topic: reference
---

# Customer.checkFieldRights(String field, String fieldRight)

Use this function to see if the current user has access to the field.

fieldRight might be:

 - read
 - write

## Example

    Customer c;
    
    c.load(3);
    Bool b = c.checkFieldRights("person","read");
    print(b.toString());

