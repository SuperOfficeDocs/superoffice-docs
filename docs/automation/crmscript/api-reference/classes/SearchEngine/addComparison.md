---
uid: crmscript_class_searchengine_addcomparison
title: SearchEngine.addComparison()
description: CRMScript method in class SearchEngine that adds a field-comparison criterion to a query
intellisense: SearchEngine.addComparison
keywords: addComparison(String,String,String,String,Integer), addComparison(String,String,String,String,String,String,Integer)
so.topic: reference
---

# addComparison()

Adds a criterion that compares 2 database fields to a database query.

You can optionally add functions to be applied to the 2 fields.

## Methods

* SearchEngine.addComparison(String field1, String compOperator, String field2, String rowOperator, Integer priority)
* SearchEngine.addComparison(String field1, String func1, String compOperator, String field2, String func2, String rowOperator, Integer priority)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| field1 | String | The field to compare to `field2` |
| func1 | String | Optional. The function to use on `field1` |
| compOperator | String | Comparison operator |
| field2 | String  The field to compare with `field1` |
| func2 | String | Optional. The function to use on `field2` |
| rowOperator | String | Operator for combining this and the next criterion |
| priority | Integer | A number. All criteria with the same number will be placed
inside the same brackets |

### Functions

[!include[ALT](../../../searchengine/includes/functions.md)]

### Row operators

[!include[ALT](../../../searchengine/includes/row-operators.md)]

### Comparison operators

[!include[ALT](../../../searchengine/includes/comp-operators.md)]
