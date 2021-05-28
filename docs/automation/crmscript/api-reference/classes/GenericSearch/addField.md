---
uid: crmscript_class_genericsearch_addfield
title: GenericSearch.addField(String field)
description: CRMScript method in the GenericSearch class that adds a field to the query
intellisense: GenericSearch.addField
sortOrder: 371
keywords: addField(String), addField(String,Integer)
so.topic: reference
---

# addField()

Adds a field to be selected to the database query. You can optionally provide a field mask.

## Methods

* GenericSearch.addField(String field)
* GenericSearch.addField(String field, Integer fieldMask)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| field | String | The name of the field to select |
| fieldMask | Integer | See below |

### fieldMask

| Mask | Description |
|---|---|
 1 | ID of the table |
 2 | Data value |
 4 | Display value |
 8 | Search value |
 16 | Sort value |
