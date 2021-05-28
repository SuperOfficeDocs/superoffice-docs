---
uid: crmscript_class_searchengine_addfield
title: SearchEngine.addField()
description: CRMScript method in the SearchEngine class that adds a field to the SELECT part of the database query
intellisense: SearchEngine.addField
keywords: addField(String), addField(String,String)
so.topic: reference
---

# addField()

Adds a field to the SELECT part of the database query.

You can optionally add a function to be applied to the field.

## Methods

* SearchEngine.addField(String field)
* SearchEngine.addField(String field, String function)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| field | String | The field to select |
| function | String | Optional. A function to use on the field |

### Available functions

* count
* avg
* sum
* max
* min
* hour
* wday
* upper
* lower
