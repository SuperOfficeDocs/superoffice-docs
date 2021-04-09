---
uid: crmscript_ref_Company_checkFieldRights_String_field_String_fieldRight
title: Company.checkFieldRights(String field, String fieldRight)
intellisense: Company.checkFieldRights
sortOrder: 157
keywords: checkFieldRights(String,String)
so.topic: reference
---

Use this function to see if the current user has access to the field.

fieldRight might be:


 - read
 - write




## Example


    Company c;
    
    c.load(3);
    Bool b = c.checkFieldRights("contact", "read");
    print(b.toString());


