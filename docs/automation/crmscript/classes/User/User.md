---
title: User
path: /EJScript/Classes/User
intellisense: 1
classref: 1
---


Class for representing a user.




###Example code:###


    User u;
    
    u.load(2); // Loads user with id = 2
    print(u.getValue("username"));
    u.setValue("email", "bob@example.com");
    u.setValue("language", "en"); // "no" or "en"
    u.setValue("status", "1"); // 1 is Active, 2 is Not Present, 3 is deleted
    print(u.isLoggedIn(2).toString()); // 2 = web pages, 1 = soap interface
    u.save();




1. autolist

