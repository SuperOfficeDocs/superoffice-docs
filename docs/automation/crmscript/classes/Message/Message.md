---
title: Message
path: /EJScript/Classes/Message
intellisense: 1
classref: 1
sortOrder: 539
---


Class for representing an eJournal ticket message.




###Example code:###


    Message m;
    
    m.load(2); // Loads message with id = 2
    m.setValue("emailHeader", "Test");
    m.setValue("body", "This is a test");
    m.save();
    m.send("bob@example.com", "simon@example.com", Null, "Test"); // To, cc, bcc, subject




1. autolist

