---
uid: crmscript_ref_NSSaleEntity_SetVisibleFor
title: SetVisibleFor(NSVisibleFor[] visibleFor)
intellisense: NSSaleEntity.SetVisibleFor
keywords: NSSaleEntity, SetVisibleFor
so.topic: reference
---

# SetVisibleFor(NSVisibleFor[] visibleFor)

Set the usergroups and/or users the SaleEntity item is visible for.

**Parameter:** 
 - **visibleFor** NSVisibleFor[] of one or more users + usergroups.

```crmscript
NSSaleEntity thing;
NSVisibleFor[] visibleFor = thing.GetVisibleFor();
visibleFor[0].SetVisiblity(1);  // usergroup
visibleFor[0].SetVisibleId(123); // usergroup id
thing.SetVisibleFor(visibleFor);
```

