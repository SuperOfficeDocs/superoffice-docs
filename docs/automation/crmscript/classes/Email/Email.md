---
title: Email
path: /EJScript/Classes/Email
intellisense: 1
classref: 1
sortOrder: 280
---

Class for representing and sending emails.



###Example code:###


    Email e;
    
    e.setValue("from", "bob@example.com");
    e.setValue("to", "allice@example.com");
    e.setValue("to", "simon@example.com"); // Value must be set once for each recipient
    e.setValue("subject", "test");
    e.setValue("body", "This is a test.");
    e.send();




1. autolist

