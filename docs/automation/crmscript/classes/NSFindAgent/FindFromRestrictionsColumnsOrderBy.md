---
title: crmscript_ref_NSFindAgent_FindFromRestrictionsColumnsOrderBy_NSArchiveRestrictionInfo__p_0_String_p_1_String__p_2_NSArchiveOrderByInfo__p_3_Integer_p_4_Integer_p_5
description: NSFindAgent.FindFromRestrictionsColumnsOrderBy(NSArchiveRestrictionInfo[] p_0, String p_1, String[] p_2, NSArchiveOrderByInfo[] p_3, Integer p_4, Integer p_5)
intellisense: NSFindAgent.FindFromRestrictionsColumnsOrderBy
sortOrder: 3674
keywords: FindFromRestrictionsColumnsOrderBy(NSArchiveRestrictionInfo[],String,String[],NSArchiveOrderByInfo[],Integer,Integer)
so.topic: reference
---


Execute a Find operation and return a page of results. \<para/>The criteria for the Find are passed in directly, not fetched by a restriction storage provider. \<para/>The desired columns of the result set are also passed in directly.\<para/>The orderby information is also passed in directly.\<para/>Use the GetCriteriaInformation, GetDefaultDesiredColumns and GetDefaultOrderBy service methods to let the system calculate these values, if you want to use or modify them.



* **restrictions:** Array of restrictions specifying the search. Each restriction must match a column of the  given archive provider, and that column must have its CanRestrictBy property set to true.
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **desiredColumns:** Array of column names desired for the result. Each name must match a column offered by the given archive provider.
* **orderBy:** Array of order by specifications. If it is null or empty, the row order is unspecified, database dependent, and might not be the same from call to call, depending on query execution plans. The unspecified order willgenerally not vary within pages of the same query.
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.
* **Returns:** Results from search, containing column information and result rows.


