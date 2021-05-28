---
uid: crmscript_class_searchengine_addhaving
title: SearchEngine.addHaving()
description: CRMScript method in the SearchEngine class that adds a HAVING clause to the database query
intellisense: SearchEngine.addHaving
keywords: addHaving(String,String,String,String,Integer), addHaving(String,String,String,String,String,Integer)
so.topic: reference
---

# addHaving()

Adds a HAVING clause to the database query.

You can optionally add a function to be applied to the field.

## Methods

* SearchEngine.addHaving(String field, String compOperator, String value, String rowOperator, Integer priority)
* SearchEngine.addHaving(String field, String function, String compOperator, String value, String rowOperator, Integer priority)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| field | String | The field to restrict |
| function | String | Optional. The function to use on `field` |
| compOperator | String | Comparison operator |
| value | String  The value to compare with `field` |
| rowOperator | String | Operator for combining this and the next criterion |
| priority | Integer | A number. All criteria with the same number will be placed
inside the same brackets |

### Functions

[!include[ALT](../../../searchengine/includes/functions.md)]

### Row operators

[!include[ALT](../../../searchengine/includes/row-operators.md)]

### Comparison operators

[!include[ALT](../../../searchengine/includes/comp-operators.md)]
