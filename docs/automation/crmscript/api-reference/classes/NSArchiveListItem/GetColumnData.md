---
uid: crmscript_ref_NSArchiveListItem_GetColumnData
title: NSColumnDataDictionary GetColumnData()
intellisense: NSArchiveListItem.GetColumnData
keywords: NSArchiveListItem, GetColumnData
so.topic: reference
---

Dictionary of column name - column data items. Each column data item contains a display value, a tooltip hint, a link hint, and an orderby value. <para/>The display value is encoded by the CultureDataFormatter and can be decoded / localized by that class; all other values are optional. <para/>Tooltip hints can be passed to the TooltipProvider (Tooltip service) to be translated into an actual tootip.

**Returns:** NSColumnDataDictionary


```crmscript
NSArchiveListItem thing;
NSColumnDataDictionary columnData  = thing.GetColumnData();
```


