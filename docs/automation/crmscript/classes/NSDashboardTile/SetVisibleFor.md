---
uid: crmscript_ref_NSDashboardTile_SetVisibleFor
title: SetVisibleFor(VisibleForArray visibleFor)
intellisense: NSDashboardTile.SetVisibleFor
keywords: NSDashboardTile, SetVisibleFor
so.topic: reference
---

Set the usergroups and/or users the DashboardTile item is visible for.

**Parameter:** 
 - **visibleFor** VisibleForArray of one or more users + usergroups.

```crmscript
NSDashboardTile thing;
VisibleFor[] visibleFor = thing.GetVisibleFor();
visibleFor[0].SetVisiblity(1);  // usergroup
visibleFor[0].SetVisibleId(123); // usergroup id
thing.SetVisibleFor(visibleFor);
```

