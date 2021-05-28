---
uid: crmscript_ref_genericsearch_get
title: GenericSearch.get(Integer field, Integer fieldMask)
description: CRMScript method in the GenericSearch class that retrieves the value of a field according to a field mask
intellisense: GenericSearch.get
sortOrder: 367
keywords: get(String,Integer), get(Integer,Integer)
so.topic: reference
---

# String get()

Retrieves the value of a field according to the given field mask. You can provide the field as either a String or an Integer.

Returns the value of the field.

## Methods

* String GenericSearch.get(Integer field, Integer fieldMask)
* String GenericSearch.get(String field, Integer fieldMask)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| field | String OR<br>Integer | The name or ID of the field to select |
| fieldMask | Integer | See below |

### fieldMask

| Mask | Description |
|---|---|
 1 | ID of the table |
 2 | Data value |
 4 | Display value |
 8 | Search value |
 16 | Sort value |
