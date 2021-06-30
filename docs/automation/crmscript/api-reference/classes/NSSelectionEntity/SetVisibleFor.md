---
uid: crmscript_ref_NSSelectionEntity_SetVisibleFor
title: SetVisibleFor(VisibleFor[] visibleFor)
intellisense: NSSelectionEntity.SetVisibleFor
keywords: NSSelectionEntity, SetVisibleFor
so.topic: reference
---

Set the usergroups and/or users the SelectionEntity item is visible for.

**Parameter:** 
 - **visibleFor** VisibleFor[] of one or more users + usergroups.

```crmscript
NSSelectionEntity thing;
VisibleFor[] visibleFor = thing.GetVisibleFor();
visibleFor[0].SetVisiblity(1);  // usergroup
visibleFor[0].SetVisibleId(123); // usergroup id
thing.SetVisibleFor(visibleFor);
```

