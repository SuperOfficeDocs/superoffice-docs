---
uid: crmscript_class_nsarchiverestrictioninfo_setisactive
title: SetIsActive(Bool isActive)
description: CRMScript method in the NSArchiveRestrictionInfo class that activates or deactivates a restriction
intellisense: NSArchiveRestrictionInfo.SetIsActive
keywords: NSArchiveRestrictionInfo, SetIsActive, SetIsActive(Bool)
so.topic: reference
---

# SetIsActive()

Is this restriction active? Inactive restrictions will not influence the generated query.

`SetIsActive(Bool isActive)`

## Parameter

| Parameter | Type | Description |
|---|---|---|
| isActive | Bool | |

## Examples

```crmscript
NSArchiveRestrictionInfo thing;
Bool isActive;
thing.SetIsActive(isActive);
```
