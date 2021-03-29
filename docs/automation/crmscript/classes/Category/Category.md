---
title: crmscript_ref_Category
description: Category
intellisense: Void.Category
sortOrder: 149
so.topic: reference
---


Class used for accessing and changing a ticket category.




###Example code:###


    Category c;
    
    c.load(2); //Loads category with id = 2
    print(c.getValue("notificationEmail"));
    c.setValue("name", "Bob");
    c.save();




1. autolist

