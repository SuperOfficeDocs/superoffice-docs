---
title: Void setBitNo(Integer number, Bool val)
path: /EJScript/Classes/FHBitSet/Member functions/Void setBitNo(Integer number, Bool val)
intellisense: 1
classref: 1
sortOrder: 339
keywords: setBitNo(Integer,Bool)
---

This function sets a specific bit.



###Parameters:###


 - number: Index of the bit to set
 - val: Value to set this bit to - (True/False - 1/0)





###Example:###
    
    FHBitSet fh;
    
    Bool b = true;
    fh.set(0);
    fh.setBitNo(15, b);
    print(fh.toLsbString());
    



###Prints:###
00000000000000001000000000000000


