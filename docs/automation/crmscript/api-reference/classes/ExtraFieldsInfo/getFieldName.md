---
uid: crmscript_ref_ExtraFieldsInfo_getFieldName
title: ExtraFieldsInfo.getFieldName()
intellisense: ExtraFieldsInfo.getFieldName
sortOrder: 306
keywords: getFieldName()
so.topic: reference
---

This function returns the field name of the current field.

## Example

This code prints all field names of extra fields:


    ExtraFieldsInfo e;
    
    e.getExtraFields("person");
    
    while(!e.eof()){
      print(e.getFieldName());
      e.next();
    }


