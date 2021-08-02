---
uid: crmscript_class_nsarchivelistitem_setcolumndata
title: SetColumnData()
description: CRMScript method in the NSArchiveListItem class that sets columnData
intellisense: NSArchiveListItem.SetColumnData
keywords: NSArchiveListItem, SetColumnData
so.topic: reference
---

# SetColumnData()

Dictionary of column name - column data items. Each column data item contains a display value, a tooltip hint, a link hint, and an ORDERBY value.

The display value is encoded by the **CultureDataFormatter** and can be decoded or localized by that class. All other values are optional.

Tooltip hints can be passed to the **TooltipProvider** (Tooltip service) to be translated into an actual too tip.

`SetColumnData(NSColumnDataDictionary columnData)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
|columnData | NSColumnDataDictionary | |

## Example

```crmscript
NSArchiveListItem thing;
NSColumnDataDictionary columnData;
thing.SetColumnData(columnData);
```
