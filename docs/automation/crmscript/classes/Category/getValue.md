---
title: String getValue(String field)
path: /EJScript/Classes/Category/member functions/String getValue(String field)
intellisense: 1
classref: 1
sortOrder: 153
keywords: getValue(String)
---

Retrieves the value of the given field in the category.



###Available fields are:###


 - id: The id of the category.
 - parent: The id of the parent category.
 - name: The name of the category.
 - fullname: The full name of the category (e.g. "Support/Product A/bugs").
 - externalName: The external name of the category.
 - categoryMaster: The id of the category master.
 - children: A comma separated list of children ids.
 - notificationEmail: The value of the email Notification field




###Parameter:###


 - field: The field to get.




###Example code:###


    Category c;
    
    c.load(2);
    print(c.getValue("name"));


