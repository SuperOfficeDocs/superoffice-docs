---
uid: crmscript_ref_Map_increaseValueForKey_String_p_0_Float_p_1
title: Map.increaseValueForKey(String p_0, Float p_1)
intellisense: Map.increaseValueForKey
sortOrder: 536
keywords: increaseValueForKey(String,Float)
so.topic: reference
---


This function will add the given float to the value of the given key.




## Parameters


 - p0: the key
 - p1: the float to add to the value




## Example


    Map m;
    m.insert("label", "5").insert("label2", "3");
    m.increaseValueForKey("label", 2.3);


