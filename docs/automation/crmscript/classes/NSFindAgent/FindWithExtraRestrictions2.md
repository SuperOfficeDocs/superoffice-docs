---
title: NSFindResults FindWithExtraRestrictions2(String storageType, String providerName, String storageKey, String extraRestrictions, String orderBy, String desiredColumns, Integer pageSize, Integer pageNumber)
path: /EJScript/Classes/NSFindAgent/Member functions/NSFindResults FindWithExtraRestrictions2(String p_0, String p_1, String p_2, String p_3, String p_4, String p_5, Integer p_6, Integer p_7)
intellisense: 1
classref: 1
sortOrder: 3680
keywords: FindWithExtraRestrictions2(String,String,String,String,String,String,Integer,Integer)
---


Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. In addition an extra set of restrictions can be added to the search. These restrictions will not be saved, they are only valid for the current search. Extra restrictions will override restrictions with the same key already stored on the storagekey.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search
* **extraRestrictions:** Extra restrictions to append to the the search. These will override saved restrictions with the same key.
* **orderBy:** Comma separated list of order by specifications. If it is null or empty, the row order is unspecified, database dependent, and might not be the same from call to call, depending on query execution plans. The unspecified order willgenerally not vary within pages of the same query.
* **desiredColumns:** Comma separated list of column names desired for the result. Each name must match a column offered by the given archive provider.
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.
* **Returns:** Results from search, containing column information and result rows.


