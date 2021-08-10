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
