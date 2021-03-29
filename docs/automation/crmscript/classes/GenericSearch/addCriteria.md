---
title: crmscript_ref_GenericSearch_addCriteria_String_field_String_operator_String_value_String_andOr_Integer_concatLevel
description: GenericSearch.addCriteria(String field, String operator, String value, String andOr, Integer concatLevel)
intellisense: GenericSearch.addCriteria
sortOrder: 370
keywords: addCriteria(String,String,String,String,Integer)
so.topic: reference
---


Add search criteria to the search.
The concatLevel which specifies how this criteria will be concatenated with the rest of the query (parenthesis level).
A higher concatLevel gives a "(", and a lower concatlevel gives a ")".



* **field:** The name of the field to select
* **operator:** The operator for the criteria, possible values:
  "OperatorNone",
  "OperatorAnd",
  "OperatorOr",
  "OperatorNotAnd",
  "OperatorNotOr",
  "OperatorLike",
  "OperatorNotLike",
  "OperatorContains",
  "OperatorBeginsWith",
  "OperatorEndsWith",
  "OperatorEquals",
  "OperatorNotEquals",
  "OperatorGt",
  "OperatorLt",
  "OperatorGte",
  "OperatorLte",
  "OperatorIn",
  "OperatorNotIn",
  "OperatorIs",
  "OperatorOracleLeftJoin",
  "OperatorIsNot",
* **value:** The value to compare with the field
* **andOr:** The operator which combine this criteria with the following criteria
  Possible values:
  OperatorAnd, OperatorOr, OperatorNotAnd, OperatorNotOr
* **concatLevel:** A number to use for combining criterias inside brackets. If the criterias has the same concatLevel, the end up inside the same brackets


