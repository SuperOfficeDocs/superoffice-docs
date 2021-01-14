---
title: NSFindResults FindFromRestrictionsColumns(NSArchiveRestrictionInfo[] restrictions, String providerName, String[] desiredColumns, Integer pageSize, Integer pageNumber)
path: /EJScript/Classes/NSFindAgent/Member functions/NSFindResults FindFromRestrictionsColumns(NSArchiveRestrictionInfo[] p_0, String p_1, String[] p_2, Integer p_3, Integer p_4)
intellisense: 1
classref: 1
sortOrder: 3672
keywords: FindFromRestrictionsColumns(NSArchiveRestrictionInfo[],String,String[],Integer,Integer)
---


Execute a Find operation and return a page of results. \<para/>The criteria for the Find are passed in directly, not fetched by a restriction storage provider. \<para/>The desired columns of the result set are also passed in directly.\<para/>The orderby information is calculated by the system.\<para/>Use the GetCriteriaInformation and GetDefaultDesiredColumns service methods to let the system calculate these values, if you want to use or modify them.



* **restrictions:** Array of restrictions specifying the search. Each restriction must match a column of the  given archive provider, and that column must have its CanRestrictBy property set to true.
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **desiredColumns:** Array of column names desired for the result. Each name must match a column offered by the given archive provider.
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.
* **Returns:** Results from search, containing column information and result rows.


