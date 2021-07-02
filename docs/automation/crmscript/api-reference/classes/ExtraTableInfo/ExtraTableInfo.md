---
uid: crmscript_ref_ExtraTableInfo
title: ExtraTableInfo
intellisense: Void.ExtraTableInfo
sortOrder: 326
so.topic: reference
---

With this class you can retrieve meta information about an extra table. The class will only retrieve information, thus it is not possible to change an extra table from this class.



## Example


    ExtraTableInfo e;
    
    e.load("y_mytable");
    print(e.getId().toString());
