---
title: Ticket
path: /EJScript/Classes/Ticket
intellisense: 1
classref: 1
sortOrder: 9172
---


Class for representing an eJournal Ticket.




###Example code:###


    Ticket t;
    
    t.load(2); // Loads the ticket with id = 2
    print(t.getValue("ticketStatus"));
    t.setValue("title", "Test");
    t.setValue("status", "1");
    DateTime d; // Default value for DateTime is now
    t.setValue("dbiLastModified", d.toString());
    print(t.getOwnerEmail()); // Prints name and email of owner
    t.save();




1. autolist

