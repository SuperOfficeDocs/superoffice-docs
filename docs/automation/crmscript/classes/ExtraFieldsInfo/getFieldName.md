---
title: crmscript_ref_ExtraFieldsInfo_getFieldName
description: ExtraFieldsInfo.getFieldName()
intellisense: ExtraFieldsInfo.getFieldName
sortOrder: 306
keywords: getFieldName()
so.topic: reference
---

This function returns the field name of the current field.



###Example that prints all field names of extra fields:###


    ExtraFieldsInfo e;
    
    e.getExtraFields("person");
    
    while(!e.eof()){
      print(e.getFieldName());
      e.next();
    }


