---
uid: crmscript_ref_NSSelectionEntity_SetVisibleFor
title: SetVisibleFor(NSVisibleFor[] visibleFor)
intellisense: NSSelectionEntity.SetVisibleFor
keywords: NSSelectionEntity, SetVisibleFor
so.topic: reference
---

# SetVisibleFor(NSVisibleFor[] visibleFor)

Set the usergroups and/or users the SelectionEntity item is visible for.

**Parameter:** 
 - **visibleFor** NSVisibleFor[] of one or more users + usergroups.

```crmscript
NSSelectionEntity thing;
NSVisibleFor[] visibleFor = thing.GetVisibleFor();
visibleFor[0].SetVisiblity(1);  // usergroup
visibleFor[0].SetVisibleId(123); // usergroup id
thing.SetVisibleFor(visibleFor);
```

