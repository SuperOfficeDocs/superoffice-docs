---
title: crmscript_ref_FHBitSet_toLsbString
description: FHBitSet.toLsbString()
intellisense: FHBitSet.toLsbString
sortOrder: 336
keywords: toLsbString()
so.topic: reference
---


This function returns a LSB (Least Significant Byte first) string representation of the bitset.





###Example:###
    
    FHBitSet fh;
    
    fh.set(44);
    print(fh.toLsbString());
    



###Prints:###
00000000000000000000000000101100


