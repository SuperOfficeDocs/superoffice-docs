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

### Row operators

| Value          | Logical operator | Expression  | Result                                     |
|----------------|:----------------:|:-----------:|--------------------------------------------|
| OperatorAnd    | AND              | A && B      | Only rows matching both conditions         |
| OperatorNotAnd | NAND             | !(A && B)   | Rows matching 0 or 1 condition but not both |
| OperatorOr     | OR               | A \|\| B    | Rows matching either condition (or both)   |
| OperatorNotOr  | NOR              | !(A \|\| B) | Only rows matching no conditions |

### Comparison operators

| Value              | Same as | Result                         |
|--------------------|:-------:|--------------------------------|
| OperatorEquals     | ==      | values match                   |
| OperatorNotEquals  | !=      | values don't match             |
| OperatorLt         | <       | value less than                |
| OperatorLte        | <=      | value less than or equal       |
| OperatorGt         | >       | value greater than             |
| OperatorGte        | >=      | value greater than or equal    |
| OperatorIs         |         | values of the same type        |
| OperatorIsNot      |         | values of different types      |
| OperatorLike       |         | pattern found in string        |
| OperatorNotLike    |         | pattern not found in string    |
| OperatorContains   |         | string is present              |
| OperatorBeginsWith |         | string starts with             |
| OperatorEndsWith   |         | string ends with               |
| OperatorIn         |         | column has entries in table    |
| OperatorNotIn      |         | column has no entries in table |
