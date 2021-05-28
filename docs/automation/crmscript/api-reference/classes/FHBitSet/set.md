---
uid: crmscript_class_fhbitset_set
title: FHBitSet.set(Integer value)
description: CRMScript method of class FHBitSet that initializes the bitset from either an Integer or a String
intellisense: FHBitSet.set
sortOrder: 337
keywords: set(Integer), set(String)
so.topic: reference
---

# Void set()

Initializes the bitset from either an Integer or a String.

## Methods

* FHBitSet.set(Integer value)
* FHBitSet.set(String rep)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| value | Integer | Used to initialize the bitset |
| rep | String | Used to initialize the bitset. For example, "1234" |

## Example

```crmscript
FHBitSet fh;

fh.set(44);
print(fh.toLsbString());
```
