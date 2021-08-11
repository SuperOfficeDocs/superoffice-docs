---
uid: crmscript_ref_ExtraFieldsInfo_getTableName
title: ExtraFieldsInfo.getTableName()
intellisense: ExtraFieldsInfo.getTableName
sortOrder: 309
keywords: getTableName()
so.topic: reference
---

# ExtraFieldsInfo.getTableName()

This function returns the name of the table the current field belongs to.

## Example
    
    ExtraFieldsInfo e;
    
    e.getExtraFields("person");
    print(e.TableName());
    
    Will print "person".

