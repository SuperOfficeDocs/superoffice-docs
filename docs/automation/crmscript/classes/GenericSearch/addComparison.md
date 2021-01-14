---
title: Void addComparison(String field1, String compOperator, String field2, String rowOperator, Integer concatLevel)
path: /EJScript/Classes/GenericSearch/Member functions/Void addComparison(String field1, String compOperator, String field2, String rowOperator, Integer concatLevel)
intellisense: 1
classref: 1
sortOrder: 369
keywords: addComparison(String,String,String,String,Integer)
---


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


