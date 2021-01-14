---
title: Void addDataField(String field1, String field2)
path: /EJScript/Classes/SearchEngine/member functions/Void addDataField(String field1, String field2)
intellisense: 1
classref: 1
sortOrder: 9007
keywords: addDataField(String,String)
---


Add a data field the SearchEngine. A data field is a field assigned to another field instead of a value.


For example.


    se.addDataField("customer.phone", "customer.cellphone");
    

Means that we are going to assign the cellphone to the phone field.

Can only be used in `update()` queries.


* **field1:** Field to assign to.
* **field2:** Field where the value is found.


