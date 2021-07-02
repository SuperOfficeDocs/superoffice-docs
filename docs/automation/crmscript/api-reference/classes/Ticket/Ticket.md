---
uid: crmscript_ref_Ticket
title: Ticket
intellisense: Void.Ticket
so.topic: reference
---


Class for representing an eJournal Ticket.




## Example


    Ticket t;
    
    t.load(2); // Loads the ticket with id = 2
    print(t.getValue("ticketStatus"));
    t.setValue("title", "Test");
    t.setValue("status", "1");
    DateTime d; // Default value for DateTime is now
    t.setValue("dbiLastModified", d.toString());
    print(t.getOwnerEmail()); // Prints name and email of owner
    t.save();
