---
uid: crmscript_ref_SearchEngine_addDataField_String_field1_String_field2
title: SearchEngine.addDataField(String field1, String field2)
intellisense: SearchEngine.addDataField
keywords: addDataField(String,String)
so.topic: reference
---


Add a data field the SearchEngine. A data field is a field assigned to another field instead of a value.


For example.


    se.addDataField("customer.phone", "customer.cellphone");
    

Means that we are going to assign the cellphone to the phone field.

Can only be used in `update()` queries.


* **field1:** Field to assign to.
* **field2:** Field where the value is found.


