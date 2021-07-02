---
uid: crmscript_ref_ExtraFieldsInfo
title: ExtraFieldsInfo
intellisense: Void.ExtraFieldsInfo
sortOrder: 301
so.topic: reference
---

With this class you can retrieve meta information about an extra field. The
class will only retrieve information, thus it is not possible to change an
extra field from this class.



## Example


    ExtraFieldsInfo e;
    
    e.getExtraFields("person"); // Finds extraFields in tabel person
    print(e.getTableName()); // Prints "person"
