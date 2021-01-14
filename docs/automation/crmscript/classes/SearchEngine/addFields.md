---
title: Void addFields(String table, String fields)
path: /EJScript/Classes/SearchEngine/member functions/Void addFields(String table, String fields)
intellisense: 1
classref: 1
sortOrder: 9011
keywords: addFields(String,String)
---


This method is a shortcut to add multiple fields to a query. The method will add all fields in the commaseparated string "fields", prefixed by "table" and a dot ".".




###Example code:###

    addFields("ticket", "id,title,category.fullname,cust_id.fullName");


