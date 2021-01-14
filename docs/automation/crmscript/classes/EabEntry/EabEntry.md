---
title: EabEntry
path: /EJScript/Classes/EabEntry
intellisense: 1
classref: 1
sortOrder: 272
---


This class enables you to read and write entries from the email address book. It is also used when you want to synchronise the address book using DBI.




###Example code:###


    EabEntry e;
    
    e.load(15);
    print(e.getValue("sms"));
    e.setValue("name", "test");
    e.save();




1. autolist

