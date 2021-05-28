---
uid: crmscript_class_searchengine_addcriteria
title: SearchEngine.addCriteria()
description: CRMScript method in class SearchEngine that adds a criterion on a database field to the database query
intellisense: SearchEngine.addCriteria
keywords: addCriteria(String,String,String), addCriteria(String,String,String,String,Integer), addCriteria(String,String,String,String,String,Integer)
so.topic: reference
---

# addCriteria()

Adds a criterion on a database field to the database query.

You can optionally add a row operator, priority, and function to be applied to the field.

## Methods

* SearchEngine.addCriteria(String field, String compOperator, String value)
* SearchEngine.addCriteria(String field, String compOperator, String value, String rowOperator, Integer priority)
* SearchEngine.addCriteria(String field, String function, String compOperator, String value, String rowOperator, Integer priority)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| field | String | The field to restrict |
| function | String | Optional. The function to use on `field` |
| compOperator | String | Comparison operator |
| value | String  The value to compare with `field` |
| rowOperator | String | Optional. Operator for combining this and the next criterion |
| priority | Integer | Optional. A number. All criteria with the same number will be placed
inside the same brackets |

### Functions

[!include[ALT](../../../searchengine/includes/functions.md)]

### Row operators

[!include[ALT](../../../searchengine/includes/row-operators.md)]

### Comparison operators

[!include[ALT](../../../searchengine/includes/comp-operators.md)]
