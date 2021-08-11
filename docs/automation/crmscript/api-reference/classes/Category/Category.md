---
uid: crmscript_ref_Category
title: Category
intellisense: Void.Category
sortOrder: 149
so.topic: reference
---

# Category

Class used for accessing and changing a ticket category.

## Example

    Category c;
    
    c.load(2); //Loads category with id = 2
    print(c.getValue("notificationEmail"));
    c.setValue("name", "Bob");
    c.save();
