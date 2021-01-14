---
title: Attachment
path: /EJScript/Classes/Attachment
intellisense: 1
classref: 1
sortOrder: 115
---


This class is used to handle eJournal attachments.




###Example code:###


    Attachment a;
    
    a.load(2); // Loads attachment with id = 2
    a.setValue("name", "test.txt");
    print(a.getValue("size")); // Size in bytes
    a.save();




1. autolist

