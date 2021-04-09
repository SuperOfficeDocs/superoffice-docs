---
uid: crmscript_ref_Attachment
title: Attachment
intellisense: Void.Attachment
sortOrder: 115
so.topic: reference
---


This class is used to handle eJournal attachments.




## Example


    Attachment a;
    
    a.load(2); // Loads attachment with id = 2
    a.setValue("name", "test.txt");
    print(a.getValue("size")); // Size in bytes
    a.save();




1. autolist

