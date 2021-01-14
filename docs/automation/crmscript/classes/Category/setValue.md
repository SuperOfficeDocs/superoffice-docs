---
title: Void setValue(String name, String value)
path: /EJScript/Classes/Category/member functions/Void setValue(String name, String value)
intellisense: 1
classref: 1
sortOrder: 154
keywords: setValue(String,String)
---

Sets the value of the given field for the category.



###The available fields are:###


 - parent: The id of the parent category.
 - name: The name of the category.
 - externalName: The external name of the category.
 - categoryMaster: The id of the category master.
 - notificationEmail: The value of the email notification field




###Parameters:###


 - name: The name of the field to set.
 - value: The value to set.




###Example code:###


    Category c;
    
    c.load(2);
    c.setValue("name", "Test");
    print(c.getValue("name"));


