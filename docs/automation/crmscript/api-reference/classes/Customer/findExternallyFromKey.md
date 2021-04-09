---
uid: crmscript_ref_Customer_findExternallyFromKey_Integer_table_String_key
title: Customer.findExternallyFromKey(Integer table, String key)
intellisense: Customer.findExternallyFromKey
sortOrder: 180
keywords: findExternallyFromKey(Integer,String)
so.topic: reference
---

Find an external entry based on it's primary key and table id.

This function will search for and possibly create a proxy entry for an external entry based on the external table (implicitly defines datasource), and the primary key.

If an proxy entry already exists, it is loaded. If not, the given external datasource is searched, and if an entry is found, a local proxy entry is created and saved.



## Parameters


 - table: The external table (ext\_table.id).
 - key: The primary key in the external table defining the entry.


Returns true if found, false if not found.


