---
uid: crmscript_ref_FHBitSet_setBitNo_Integer_number_Bool_val
title: FHBitSet.setBitNo(Integer number, Bool val)
intellisense: FHBitSet.setBitNo
sortOrder: 339
keywords: setBitNo(Integer,Bool)
so.topic: reference
---

# FHBitSet.setBitNo(Integer number, Bool val)

This function sets a specific bit.

## Parameters

 - number: Index of the bit to set
 - val: Value to set this bit to - (True/False - 1/0)

## Example
    
    FHBitSet fh;
    
    Bool b = true;
    fh.set(0);
    fh.setBitNo(15, b);
    print(fh.toLsbString());

**Output:**

00000000000000001000000000000000
