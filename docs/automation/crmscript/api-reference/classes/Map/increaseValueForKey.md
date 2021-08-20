---
uid: crmscript_class_map_increasevalueforkey
title: Map.increaseValueForKey()
description: CRMScript method of class Map that increments the value associated with the given key by the given amount
intellisense: Map.increaseValueForKey
sortOrder: 536
keywords: increaseValueForKey(String,Float), increaseValueForKey(String,Integer)
so.topic: reference
---

# increaseValueForKey()

Increments the value of the given key by the amount specified. You can pass the increment as either Integer or Float.

## Methods

* Map.increaseValueForKey(String key, Integer increment)
* Map.increaseValueForKey(String key, Float increment)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| key | String | The key for which to update the value |
| increment | Integer OR<or> Float | The amount to add to the current value |

## Example

```crmscript
Map m;
m.insert("label", "5").insert("label2", "3");
m.increaseValueForKey("label", 2);
```

```crmscript
Map m;
m.insert("label", "5").insert("label2", "3");
m.increaseValueForKey("label", 2.3);
```
