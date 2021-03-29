---
title: crmscript_ref_NSFindAgent_Find_String_p_0_String_p_1_String_p_2_Integer_p_3_Integer_p_4
description: NSFindAgent.Find(String p_0, String p_1, String p_2, Integer p_3, Integer p_4)
intellisense: NSFindAgent.Find
sortOrder: 3669
keywords: Find(String,String,String,Integer,Integer)
so.topic: reference
---


Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. The columns of the result are calculated based on the restriction. The orderby columns are also calculated by the system.\<para/>The other variants of the Find method allow you greater control over the individual aspects of the process.



* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.
* **Returns:** Results from search, containing column information and result rows.


