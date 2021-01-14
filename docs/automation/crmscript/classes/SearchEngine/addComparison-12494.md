---
title: Void addComparison(String field1, String func1, String compOperator, String field2, String func2, String rowOperator, Integer priority)
path: /EJScript/Classes/SearchEngine/member functions/Void addComparison(String field1, String func1, String compOperator, String field2, String func2, String rowOperator, Integer priority)
intellisense: 1
classref: 1
sortOrder: 9002
keywords: addComparison(String,String,String,String,String,String,Integer)
---


Sets a criteria that is a comparison between to fields in the database




* **field1:** The field to make compare with field2
* **func1:** The function to use on field1
  Possible values:
  FuncCount, FuncAvg, FuncSum, FuncMax, FuncMin, FuncHour,
  FuncWDay, FuncUpper, FuncLower
* **compOperator:** Comparison operator. Possible values:
  OperatorEquals, OperatorNotEquals, OperatorLt, OperatorLte, OperatorGt,
  OperatorGte, OperatorLike, OperatorNotLike, OperatorContains,
  OperatorBeginsWith, OperatorEndsWith, OperatorIn, OperatorNotIn,
  OperatorIs, OperatorOracleLeftJoin, OperatorIsNot
* **field2:** The field to compare with field1
* **func2:** The function to use on field2
  Possible values:
  FuncCount, FuncAvg, FuncSum, FuncMax, FuncMin, FuncHour,
  FuncWDay, FuncUpper, FuncLower
* **rowOperator:** Operator for composing this criteria with a following
  criteria
  Possible values
  OperatorAnd, OperatorOr, OperatorNotAnd, OperatorNotOr
* **priority:** A number. All criterias with the same number will be placed
  inside the same brackets


