---
title: crmscript_ref_StatLib_addGroup_Integer_p_0_Bool_p_1_Bool_compareAsNumber
description: StatLib.addGroup(Integer p_0, Bool p_1, Bool compareAsNumber)
intellisense: StatLib.addGroup
keywords: addGroup(Integer,Bool,Bool)
so.topic: reference
---


* **column:** The column to use as the group identifier (i.e. the field which will identify the groups).
* **desc:** If True, then we'll sort this group descending, otherwise ascending.
* **compareAsNumber:** True if the value is a number and you want numeric sorting/grouping


Add a group to the StatLib instance. A group is a subset of the results which
has a common value for a given column. Aggregate values can be calculated for
groups (i.e. avergage response time pr. category).


