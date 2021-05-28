---
uid: crmscript_class_nsversioninfo_setcheckedindate
title: SetCheckedInDate()
description: CRMScript method in the NSVersionInfo class that sets the date that this version was checked in
intellisense: NSVersionInfo.SetCheckedInDate
keywords: NSVersionInfo, GetCheckedInDate, SetCheckedInDate(DateTime)
so.topic: reference
---

# SetCheckedInDate()

The date that this version was checked in and became official

`SetCheckedInDate(DateTime checkedInDate)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| checkedInDate | DateTime | The date that this version was checked in and became official |

## Examples

```crmscript
NSVersionInfo thing;
DateTime checkedInDate;
thing.SetCheckedInDate(checkedInDate);
```
