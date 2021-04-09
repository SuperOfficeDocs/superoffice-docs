---
uid: crmscript_ref_ExtraTable_setValue_String_fieldname_String_value
title: ExtraTable.setValue(String fieldname, String value)
intellisense: ExtraTable.setValue
sortOrder: 325
keywords: setValue(String,String)
so.topic: reference
---

This function sets the value of a given field if it exists.



## Parameters


 - fieldname: Name of field to set
 - value: A string representation of the value to be assigned to the field.




## Example


    ExtraTable ex;
    
    Bool b = ex.load(2);
    print(b.toString());
    
    ex.setValue("name", "Test");
    print(ex.getValue("x_table"));


