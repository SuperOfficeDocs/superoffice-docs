---
uid: crmscript_ref_FHBitSet
title: FHBitSet
intellisense: Void.FHBitSet
sortOrder: 332
so.topic: reference
---

# FHBitSet

This class is used to represent and manipulate a 32 bit bitset.

## Example

    FHBitSet fh;
    
    fh.set(43);
    fh.setBitNo(15, true);
    printLine(fh.toLsbString()); // Prints "00000000000000001000000000101011"
    printLine(fh.toInteger().toString()); // prints "32811"
