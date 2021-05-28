---
uid: crmscript_class_statresult_getfield
title: StatResult.getField()
intellisense: StatResult.getField
keywords: getField(Integer), getField(String)
so.topic: reference
---

# getField()

Returns the value for the given field at the current row. You can specify the field either by its name or its column. Normally used to retrieve values from aggregate functions.

## Methods

* StatResult.getField(Integer column)
* StatResult.getField(String field)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| column | Integer | The zero-based index of columns. |
| field | String | The name of the field to retrieve. |
