---
title: Void setValue(String fieldname, String value)
path: /EJScript/Classes/ExtraTable/Member functions/Void setValue(String fieldname, String value)
intellisense: 1
classref: 1
sortOrder: 325
keywords: setValue(String,String)
---

This function sets the value of a given field if it exists.



###Parameters:###


 - fieldname: Name of field to set
 - value: A string representation of the value to be assigned to the field.




###Example code:###


    ExtraTable ex;
    
    Bool b = ex.load(2);
    print(b.toString());
    
    ex.setValue("name", "Test");
    print(ex.getValue("x_table"));


