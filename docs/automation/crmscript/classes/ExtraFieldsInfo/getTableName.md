---
title: crmscript_ref_ExtraFieldsInfo_getTableName
description: ExtraFieldsInfo.getTableName()
intellisense: ExtraFieldsInfo.getTableName
sortOrder: 309
keywords: getTableName()
so.topic: reference
---


This function returns the name of the table the current field belongs to.





###Example:###
    
    ExtraFieldsInfo e;
    
    e.getExtraFields("person");
    print(e.TableName());
    
    Will print "person".


