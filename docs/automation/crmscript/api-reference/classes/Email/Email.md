---
uid: crmscript_ref_Email
title: Email
intellisense: Void.Email
sortOrder: 280
so.topic: reference
---

# Email

Class for representing and sending emails.

## Example

    Email e;
    
    e.setValue("from", "bob@example.com");
    e.setValue("to", "allice@example.com");
    e.setValue("to", "simon@example.com"); // Value must be set once for each recipient
    e.setValue("subject", "test");
    e.setValue("body", "This is a test.");
    e.send();
