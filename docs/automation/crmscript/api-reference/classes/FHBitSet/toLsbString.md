---
uid: crmscript_ref_FHBitSet_toLsbString
title: FHBitSet.toLsbString()
intellisense: FHBitSet.toLsbString
sortOrder: 336
keywords: toLsbString()
so.topic: reference
---


This function returns a LSB (Least Significant Byte first) string representation of the bitset.





## Example
    
    FHBitSet fh;
    
    fh.set(44);
    print(fh.toLsbString());

**Output:**

00000000000000000000000000101100
