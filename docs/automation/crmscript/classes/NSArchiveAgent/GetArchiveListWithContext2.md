---
title: crmscript_ref_NSArchiveAgent_GetArchiveListWithContext2_String_p_0_String_p_1_String_p_2_String_p_3_String_p_4_Integer_p_5_Integer_p_6_String_p_7
description: NSArchiveAgent.GetArchiveListWithContext2(String p_0, String p_1, String p_2, String p_3, String p_4, Integer p_5, Integer p_6, String p_7)
intellisense: NSArchiveAgent.GetArchiveListWithContext2
sortOrder: 1112
keywords: GetArchiveListWithContext2(String,String,String,String,String,Integer,Integer,String)
so.topic: reference
---


Get a page of data for an archive using restrictions as strings, with context parameter. The columns returned will be those set as chosen columns, using either the SetChosenColumns service or the corresponding SelectableMDOList.SetSelected.



* **guiName:** The GUI name of the archive list, used to retrieve the currently configured set of columns (otherwise manipulated using the ArchiveConfiguration service)
* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **sortOrder:** Sort order for the archive. e.g. "name asc, dept desc" Can be null, which indicates 'no particular order'
* **restriction:** Archive restrictions as string. e.g. "name gt 'B' or dept = 'baz'" Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
* **entities:** Comma separated list of entities to include. Can be null, which indicates 'include all entities'
* **page:** Page number, page 0 is the first page. Negative page numbers are interpreted as number of rows to skip.
* **pageSize:** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)
* **context:** Context parameter, url-encoded string context parameter for ArchiveProvider constructor
* **Returns:** Array of archive list items, where each item represents one row of data (row level data + the requested columns)


