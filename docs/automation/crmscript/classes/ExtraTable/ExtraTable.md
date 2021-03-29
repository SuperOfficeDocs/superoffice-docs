---
title: crmscript_ref_ExtraTable
description: ExtraTable
intellisense: Void.ExtraTable
sortOrder: 316
so.topic: reference
---

A class to access eJournal extra tables - create, edit and delete entries.



###Example code:###


    ExtraTable e;
    
    e.load(2); // Loads ExtraTable with id = 2
    e.setValue("fieldname", "Test");
    e.setValue("value", "43");
    print(e.getValue("Test"));
    e.save();




1. autolist

