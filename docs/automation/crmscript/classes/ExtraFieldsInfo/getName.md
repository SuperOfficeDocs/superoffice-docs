---
title: crmscript_ref_ExtraFieldsInfo_getName
description: ExtraFieldsInfo.getName()
intellisense: ExtraFieldsInfo.getName
sortOrder: 307
keywords: getName()
so.topic: reference
---

This function returns the descriptive name (not the database name) of the current field.



###Example that prints all names of extra fields:###

    ExtraFieldsInfo e;
    
    e.getExtraFields("person");
    
    while(!e.eof()) {
      print(e.getName());
      e.next();
    }


