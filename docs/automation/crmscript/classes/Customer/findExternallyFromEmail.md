---
uid: crmscript_ref_Customer_findExternallyFromEmail_String_email_Integer_extTable
title: Customer.findExternallyFromEmail(String email, Integer extTable)
intellisense: Customer.findExternallyFromEmail
sortOrder: 174
keywords: findExternallyFromEmail(String,Integer)
so.topic: reference
---

Find an entry in the external database based on an email address

This function will search all external datasources for a Customer matching the given email address. If an entry is found, a proxy entry is created and saved.



###Parameters:###


 - email: The email address ("alias@domain").
 - extTable: is used if you only want to search one datasource


Returns true if an entry is found, false if not.


