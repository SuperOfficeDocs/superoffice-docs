---
uid: crmscript_ref_Map_increaseValueForKey_String_p_0_Integer_p_1
title: Map.increaseValueForKey(String p_0, Integer p_1)
intellisense: Map.increaseValueForKey
sortOrder: 537
keywords: increaseValueForKey(String,Integer)
so.topic: reference
---

This function will add the given integer to the value of the given key.



## Parameters


 - p0: the key
 - p1: the integer to add to the value




## Example


    Map m;
    m.insert("label", "5").insert("label2", "3");
    m.increaseValueForKey("label", 2);


