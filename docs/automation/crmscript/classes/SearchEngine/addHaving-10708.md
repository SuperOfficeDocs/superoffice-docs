---
uid: crmscript_ref_SearchEngine_addHaving_String_field_String_func_String_compOperator_String_value_String_rowOperator_Integer_priority
title: SearchEngine.addHaving(String field, String func, String compOperator, String value, String rowOperator, Integer priority)
intellisense: SearchEngine.addHaving
keywords: addHaving(String,String,String,String,String,Integer)
so.topic: reference
---


Adds a having-clause to the database-query



* **field:** The field to make a restiction on
* **function:** The function to use on the field Possible values:
 FuncCount, FuncAvg, FuncSum, FuncMax, FuncMin, FuncHour,
 FuncWDay, FuncUpper, FuncLower
* **compOperator:** Comparison operator. Possible values:
 OperatorEquals, OperatorNotEquals, OperatorLt, OperatorLte, OperatorGt,
 OperatorGte, OperatorLike, OperatorNotLike, OperatorContains,
 OperatorBeginsWith, OperatorEndsWith, OperatorIn, OperatorNotIn,
 OperatorIs, OperatorOracleLeftJoin, OperatorIsNot
* **value:** The value to be compared with the field
* **rowOperator:** Operator for composing this criteria with a following
criteria
   
**Possible values:**   
 OperatorAnd, OperatorOr, OperatorNotAnd, OperatorNotOr
* **priority:** A number. All criterias with the same number will be placed
inside
the same brackets


