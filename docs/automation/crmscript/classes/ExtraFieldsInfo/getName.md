---
title: String getName()
path: /EJScript/Classes/ExtraFieldsInfo/Member functions/String getName()
intellisense: 1
classref: 1
sortOrder: 307
keywords: getName()
---

This function returns the descriptive name (not the database name) of the current field.



###Example that prints all names of extra fields:###

    ExtraFieldsInfo e;
    
    e.getExtraFields("person");
    
    while(!e.eof()) {
      print(e.getName());
      e.next();
    }


