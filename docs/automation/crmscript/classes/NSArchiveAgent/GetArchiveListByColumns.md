---
title: crmscript_ref_NSArchiveAgent_GetArchiveListByColumns_String_p_0_String__p_1_NSArchiveOrderByInfo__p_2_NSArchiveRestrictionInfo__p_3_String__p_4_Integer_p_5_Integer_p_6
description: NSArchiveAgent.GetArchiveListByColumns(String p_0, String[] p_1, NSArchiveOrderByInfo[] p_2, NSArchiveRestrictionInfo[] p_3, String[] p_4, Integer p_5, Integer p_6)
intellisense: NSArchiveAgent.GetArchiveListByColumns
sortOrder: 1107
keywords: GetArchiveListByColumns(String,String[],NSArchiveOrderByInfo[],NSArchiveRestrictionInfo[],String[],Integer,Integer)
so.topic: reference
---


Get a page of results for an archive list, explicitly specifying the restrictions, orderby and chosen columns.



* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **columns:** An array of the names of the columns wanted.
* **sortOrder:** Sort order for the archive. Can be null, which indicates 'no particular order'
* **restriction:** Archive restrictions. Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
* **entities:** Which entities to include. Can be null, which indicates 'include all entities'
* **page:** Page number, page 0 is the first page. Negative page numbers are interpreted as number of rows to skip.
* **pageSize:** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)
* **Returns:** Array of archive list items, where each item represents one row of data (row level data + the requested columns)


