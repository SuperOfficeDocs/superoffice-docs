---
uid: crmscript_ref_NSSaleEntity_SetVisibleFor
title: SetVisibleFor(VisibleFor[] visibleFor)
intellisense: NSSaleEntity.SetVisibleFor
keywords: NSSaleEntity, SetVisibleFor
so.topic: reference
---

Set the usergroups and/or users the SaleEntity item is visible for.

**Parameter:** 
 - **visibleFor** VisibleFor[] of one or more users + usergroups.

```crmscript
NSSaleEntity thing;
VisibleFor[] visibleFor = thing.GetVisibleFor();
visibleFor[0].SetVisiblity(1);  // usergroup
visibleFor[0].SetVisibleId(123); // usergroup id
thing.SetVisibleFor(visibleFor);
```

