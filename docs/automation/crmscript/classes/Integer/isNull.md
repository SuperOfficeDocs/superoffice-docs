---
title: Bool isNull()
path: /EJScript/Classes/Integer/Member functions/Bool isNull()
intellisense: 1
classref: 1
sortOrder: 424
keywords: isNull()
---


This function returns true if the Integer is NULL/NUL/NIL.


A NULL/NUL/NIL Integer is different from zero, in that it is conceptually without a value. However, when a null Integer is used naively, ejScript is usually forgiving and interprets it as zero.




###Example:###
    
    Integer i = 3;
    print(i.isNull().toString());
    
    Prints false.


