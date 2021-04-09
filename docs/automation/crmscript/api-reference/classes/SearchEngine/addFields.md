---
uid: crmscript_ref_SearchEngine_addFields_String_table_String_fields
title: SearchEngine.addFields(String table, String fields)
intellisense: SearchEngine.addFields
keywords: addFields(String,String)
so.topic: reference
---


This method is a shortcut to add multiple fields to a query. The method will add all fields in the commaseparated string "fields", prefixed by "table" and a dot ".".




## Example

    addFields("ticket", "id,title,category.fullname,cust_id.fullName");


