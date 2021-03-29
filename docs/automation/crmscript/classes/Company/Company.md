---
title: crmscript_ref_Company
description: Company
intellisense: Void.Company
sortOrder: 155
so.topic: reference
---

Class for representing a company



###Example code:###


    Company c;
    
    c.load(2); // Loads company with id = 2
    print(c.getValue("primContact"));
    c.setValue("name", "SuperOffice");
    Bool b = c.checkFieldRights("contact", "read");
    print(b.toString());
    c.save();




1. autolist

