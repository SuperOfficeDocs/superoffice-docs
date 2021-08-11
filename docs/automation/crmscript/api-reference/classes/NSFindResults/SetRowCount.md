---
uid: crmscript_ref_NSFindResults_SetRowCount
title: SetRowCount(Integer rowCount)
intellisense: NSFindResults.SetRowCount
keywords: NSFindResults, GetRowCount
so.topic: reference
---

# SetRowCount(Integer rowCount)

Count of rows, independent of paging. If you order up page 1 with page size 50, the row count may still be 279, that being the number of rows that would have been returned in a  paging-off situation

**Parameter:** 
 - **rowCount** Integer

```crmscript
NSFindResults thing;
Integer rowCount;
thing.SetRowCount(rowCount);
```

