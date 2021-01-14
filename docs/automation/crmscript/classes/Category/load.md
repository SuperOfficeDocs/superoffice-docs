---
title: Bool load(Integer id)
path: /EJScript/Classes/Category/member functions/Bool load(Integer id)
intellisense: 1
classref: 1
sortOrder: 151
keywords: load(Integer)
---

Load object with values from category with given id.



###Parameter:###


 - id: The id of the category to load.


Returns true if the category exists, otherwise false.



###Example code:###


    Category c;
    
    c.load(2);
    print(c.getValue("name"));


