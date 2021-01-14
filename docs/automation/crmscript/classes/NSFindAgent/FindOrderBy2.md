---
title: NSFindResults FindOrderBy2(String storageType, String providerName, String storageKey, Integer pageSize, Integer pageNumber, String orderBy)
path: /EJScript/Classes/NSFindAgent/Member functions/NSFindResults FindOrderBy2(String p_0, String p_1, String p_2, Integer p_3, Integer p_4, String p_5)
intellisense: 1
classref: 1
sortOrder: 3677
keywords: FindOrderBy2(String,String,String,Integer,Integer,String)
---


Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. The columns of the result are calculated based on the restriction. The orderby parameter is used for sorting the results.\<para/>The other variants of the Find method allow you greater control over the individual aspects of the process.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.
* **orderBy:** Comma separated list of order by specifications. "name asc, dept desc" If it is null or empty, the row order is unspecified, database dependent, and might not be the same from call to call, depending on query execution plans. The unspecified order willgenerally not vary within pages of the same query.
* **Returns:** Results from search, containing column information and result rows.


