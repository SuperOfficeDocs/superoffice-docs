---
uid: crmscript_ref_NSFindAgent_GetDefaultOrderByFromDesiredColumns
title: ArchiveOrderByInfoArray GetDefaultOrderByFromDesiredColumns(String providerName, StringArray desiredColumns)
intellisense: NSFindAgent.GetDefaultOrderByFromDesiredColumns
keywords: NSFindAgent, GetDefaultOrderByFromDesiredColumns
so.topic: reference
---

Calculate the default orderby columns for a given provider and a set of desired columns. This is the same algorithm that is used by the Find service method.

**Parameters:**
 - **providerName** Provider name to calculate default orderby for
 - **desiredColumns** Desired columns (return fields), used in the orderby calculation. You can generally only order by columns that have been set as 'desired'.

**Returns:** Orderby information

```crmscript
NSFindAgent agent;
String providerName;
StringArray desiredColumns;
ArchiveOrderByInfoArray res = agent.GetDefaultOrderByFromDesiredColumns(providerName, desiredColumns);
```

