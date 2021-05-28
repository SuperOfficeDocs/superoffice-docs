---
uid: crmscript_class_statlib_addaggregate
title: StatLib.addAggregate()
description: CRMScript method in the StatLib class that add an aggregate function to the specified group
intellisense: StatLib.addAggregate
keywords: addAggregate(Integer,Integer,String,String,Integer), addAggregate(Integer,Integer,String,String,Integer,Integer)
so.topic: reference
---

# addAggregate()

Adds an aggregate function to the specified group. An **aggregate function** is a function that is calculated for all values for a given column in a group. For example, the average response time for each category.

You can optionally signal to calculate only for the rows that have a unique value in this column.

## Functions

* StatLib.addAggregate(Integer groupColumn, Integer column, String name, String type, Integer decimals)
* StatLib.addAggregate(Integer groupColumn, Integer column, String name, String type, Integer decimals, Integer uniqueColumn)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| groupColumn | Integer | The column used for grouping. |
| column | Integer | The column used for the calculation. |
| name | String | The name of the calculated variable in the Parser or StatResult |
| type | String | The type of function. |
| decimals | Integer | The number of decimals to use in the calculated value |
| uniqueColumn | Integer | Optional. The value is only calculated for the rows which have a unique value in this column. |

### Available functions

* Count
* Sum
* Avg
* Max
* Min
* CountNotEmpty
