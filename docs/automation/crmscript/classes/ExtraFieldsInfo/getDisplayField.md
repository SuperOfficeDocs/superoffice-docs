---
uid: crmscript_ref_ExtraFieldsInfo_getDisplayField
title: ExtraFieldsInfo.getDisplayField()
intellisense: ExtraFieldsInfo.getDisplayField
sortOrder: 305
keywords: getDisplayField()
so.topic: reference
---

This function returns the display field of the current field. The display field is a format of the field that can be used to address the field in functions such as SearchEngine.




###Example:###
    
    ExtraFieldsInfo e;
    
    e.getExtraFields("person");
    print(e.getDisplayField());


