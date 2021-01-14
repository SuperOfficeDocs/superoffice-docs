---
title: String getFieldName()
path: /EJScript/Classes/ExtraFieldsInfo/Member functions/String getFieldName()
intellisense: 1
classref: 1
sortOrder: 306
keywords: getFieldName()
---

This function returns the field name of the current field.



###Example that prints all field names of extra fields:###


    ExtraFieldsInfo e;
    
    e.getExtraFields("person");
    
    while(!e.eof()){
      print(e.getFieldName());
      e.next();
    }


