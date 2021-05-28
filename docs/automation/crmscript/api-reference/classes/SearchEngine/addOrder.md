---
uid: crmscript_class_searchengine_addorder
title: SearchEngine.addOrder()
description: CRMScript method in the CRMScript class that adds a restriction to the order on the listing of the database result
intellisense: SearchEngine.addOrder
keywords: addOrder(String,Bool), addOrder(String,String,Bool)
so.topic: reference
---

# addOrder()

Adds a restriction to the order on the listing of the database result.

You can optionally add a function to be applied to the field.

## Methods

* SearchEngine.addOrder(String field, Bool ascending)
* SearchEngine.addOrder(String field, String function, Bool ascending)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| field | String | The field to restrict |
| function | String | Optional. The function to use on `field` |
| ascending | Bool | The sort order. True = ascending, false = descending |

### Available functions

* Count
* Avg
* Sum
* Max
* Min
* Hour
* WDay
* Upper
* Lower
