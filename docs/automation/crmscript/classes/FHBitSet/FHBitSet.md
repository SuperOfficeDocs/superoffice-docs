---
title: FHBitSet
path: /EJScript/Classes/FHBitSet
intellisense: 1
classref: 1
sortOrder: 332
---


This class is used to represent and manipulate a 32 bit bitset.




###Example code:###


    FHBitSet fh;
    
    fh.set(43);
    fh.setBitNo(15, true);
    printLine(fh.toLsbString()); // Prints "00000000000000001000000000101011"
    printLine(fh.toInteger().toString()); // prints "32811"




1. autolist

