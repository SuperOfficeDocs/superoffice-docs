---
title: crmscript_ref_Email
description: Email
intellisense: Void.Email
sortOrder: 280
so.topic: reference
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

