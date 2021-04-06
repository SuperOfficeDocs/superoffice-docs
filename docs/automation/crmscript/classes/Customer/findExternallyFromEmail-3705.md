---
uid: crmscript_ref_Customer_findExternallyFromEmail_String_p_0
title: Customer.findExternallyFromEmail(String p_0)
intellisense: Customer.findExternallyFromEmail
sortOrder: 175
keywords: findExternallyFromEmail(String)
so.topic: reference
---

Find an entry in the external database based on an email address

This function will search all external datasources for a Customer matching the given email address. If an entry is found, a proxy entry is created and saved.



###Parameter:###


 - email: The email address ("alias@domain").


Returns true if an entry is found, false if not.


