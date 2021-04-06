---
uid: crmscript_ref_NSArchiveListResult_GetRowCount
title: Integer GetRowCount()
intellisense: NSArchiveListResult.GetRowCount
keywords: NSArchiveListResult, GetRowCount
so.topic: reference
---

Count of rows, independent of paging. If you order up page 1 with page size 50, the row count may still be 279, that being the number of rows that would have been returned in a  paging-off situation

**Returns:** Integer


```crmscript
NSArchiveListResult thing;
Integer rowCount  = thing.GetRowCount();
```


