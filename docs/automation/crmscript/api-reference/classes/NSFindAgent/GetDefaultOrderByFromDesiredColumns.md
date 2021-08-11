---
uid: crmscript_ref_NSFindAgent_GetDefaultOrderByFromDesiredColumns
title: NSArchiveOrderByInfo[] GetDefaultOrderByFromDesiredColumns(String providerName, String[] desiredColumns)
intellisense: NSFindAgent.GetDefaultOrderByFromDesiredColumns
keywords: NSFindAgent, GetDefaultOrderByFromDesiredColumns
so.topic: reference
---

# NSArchiveOrderByInfo[] GetDefaultOrderByFromDesiredColumns(String providerName, String[] desiredColumns)

Calculate the default orderby columns for a given provider and a set of desired columns. This is the same algorithm that is used by the Find service method.

**Parameters:**
 - **providerName** Provider name to calculate default orderby for
 - **desiredColumns** Desired columns (return fields), used in the orderby calculation. You can generally only order by columns that have been set as 'desired'.

**Returns:** NSArchiveOrderByInfo[]

```crmscript
NSFindAgent agent;
String providerName;
String[] desiredColumns;
NSArchiveOrderByInfo[] res = agent.GetDefaultOrderByFromDesiredColumns(providerName, desiredColumns);
```

