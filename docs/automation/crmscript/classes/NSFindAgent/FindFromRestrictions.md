---
title: NSFindResults FindFromRestrictions(NSArchiveRestrictionInfo[] restrictions, String providerName, Integer pageSize, Integer pageNumber)
path: /EJScript/Classes/NSFindAgent/Member functions/NSFindResults FindFromRestrictions(NSArchiveRestrictionInfo[] p_0, String p_1, Integer p_2, Integer p_3)
intellisense: 1
classref: 1
sortOrder: 3670
keywords: FindFromRestrictions(NSArchiveRestrictionInfo[],String,Integer,Integer)
---


Execute a Find operation and return a page of results. The criteria for the Find are passed in directly, not fetched by a restriction storage provider. The columns of the result are calculated based on the restriction.



* **restrictions:** Array of restrictions specifying the search. Each restriction must match a column of the  given archive provider, and that column must have its CanRestrictBy property set to true.
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.
* **Returns:** Results from search, containing column information and result rows.


