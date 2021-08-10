---
uid: crmscript_class_searchengine_getfield
title: SearchEngine.getField()
description: CRMScript method in the SearchEngine class that returns the value of a field
intellisense: SearchEngine.getField
keywords: getField(Integer), getField(String), getField(String,String)
so.topic: reference
---

# getField()

Returns the value of a field. You can provide the field as either an Integer or a String.

You can optionally add a function to be applied to the field when using the name as the identifier.

## Methods

* SearchEngine.getField(Integer num)
* SearchEngine.getField(String name)
* SearchEngine.getField(String name, String function)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| num | Integer | The number of the field. Starting at 0. Alternative to using `name` |
| name | String | The name of the field. On the form **table.fieldname**. Alternative to using `num` |
| function | String | Optional. The function to use on the field. Used in combination with `name` |

### Functions

| Function | Other name | Applies to     | bypassNetServer | Description |
|----------|------------|----------------|:---------------:|-------------|
| avg      | FuncAvg    | Integer, Float |     yes         | aggregate, the average value of a column          |
| count    | FuncCount  | Integer, Float |     yes         | aggregate, the number of rows matching cond.            |
| sum      | FuncSum    | Integer, Float |     yes         |aggregate, the total sum of a column            |
| max      | FuncMax    | Integer, Float |     yes         | aggregate, the largest value of a column            |
| min      | FuncMin    | Time, DateTime |                 |            |
| hour     | FuncHour   | Time, DateTime |                 |            |
| wday     | FuncWDay   | Date, DateTime |                 |            |
| upper    | FuncUpper  | String         |                 |            |
| lower    | FuncLower  | String         |                 |            |
