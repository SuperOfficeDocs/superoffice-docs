---
title: Map insert(String key, String value)
path: /EJScript/Classes/Map/Member functions/Map insert(String key, String value)
intellisense: 1
classref: 1
sortOrder: 529
keywords: insert(String,String)
---

Insert a new key-value pair in the map. This function will reset the internal iterator in the map.



###Parameters:###


 - key: The key.
 - value: the value to insert.


From version 7.1 the function will return a reference to itself, allowing you to use code like this to initialize a map:



###Example code:###


    Map().insert("foo", "bar").insert("Super", "Office");


