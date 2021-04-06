---
uid: crmscript_ref_Map_insert_String_key_String_value
title: Map.insert(String key, String value)
intellisense: Map.insert
sortOrder: 529
keywords: insert(String,String)
so.topic: reference
---

Insert a new key-value pair in the map. This function will reset the internal iterator in the map.



###Parameters:###


 - key: The key.
 - value: the value to insert.


From version 7.1 the function will return a reference to itself, allowing you to use code like this to initialize a map:



###Example code:###


    Map().insert("foo", "bar").insert("Super", "Office");


