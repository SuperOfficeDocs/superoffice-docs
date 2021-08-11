---
uid: crmscript_ref_GenericSearch_addComparison_String_field1_String_compOperator_String_field2_String_rowOperator_Integer_concatLevel
title: GenericSearch.addComparison(String field1, String compOperator, String field2, String rowOperator, Integer concatLevel)
intellisense: GenericSearch.addComparison
sortOrder: 369
keywords: addComparison(String,String,String,String,Integer)
so.topic: reference
---

# GenericSearch.addComparison(String field1, String compOperator, String field2, String rowOperator, Integer concatLevel)

Adds a criteria between two database-fields to the database query

* **field1:** The field to compare with field2
* **compOperator:** Comparison operator. Possible values:
OperatorEquals, OperatorNotEquals, OperatorLt, OperatorLte, OperatorGt,
OperatorGte, OperatorLike, OperatorNotLike, OperatorContains,
OperatorBeginsWith, OperatorEndsWith, OperatorIn, OperatorNotIn,
OperatorIs, OperatorOracleLeftJoin, OperatorIsNot
* **field2:** The field to compare with field1
* **rowOperator:** Operator for composing this criteria with a following
criteria
   
**Possible values**   
OperatorAnd, OperatorOr, OperatorNotAnd, OperatorNotOr
* **concatLevel:** A number. All criterias with the same number will be placed
inside the same brackets

