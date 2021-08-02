---
uid: crmscript_ref_NSDashboardTile_SetVisibleFor
title: SetVisibleFor(NSVisibleFor[] visibleFor)
intellisense: NSDashboardTile.SetVisibleFor
keywords: NSDashboardTile, SetVisibleFor
so.topic: reference
---

Set the usergroups and/or users the NSDashboardTile item is visible for.

**Parameter:** 
 - **visibleFor** NSVisibleFor[] of one or more users + usergroups.

```crmscript
NSDashboardTile thing;
NSVisibleFor[] visibleFor = thing.GetVisibleFor();
visibleFor[0].SetVisiblity(1);  // usergroup
visibleFor[0].SetVisibleId(123); // usergroup id
thing.SetVisibleFor(visibleFor);
```

