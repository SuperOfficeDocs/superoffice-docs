---
title: crmscript_ref_MainMenu_deleteGroup_Integer_index
description: MainMenu.deleteGroup(Integer index)
intellisense: MainMenu.deleteGroup
sortOrder: 518
keywords: deleteGroup(Integer)
so.topic: reference
---

### Void deleteGroup(Integer position)

Removes the group at the given index from the main menu.

> [!TIP]
> Verify that you're removing the correct group by checking with `getGroupId()` what's in that slot first.

```crmscript
Integer pos = 3;
MainMenu menu = getMainMenu();
if (menu.getGroupId(pos) == "my label") {
  menu.deleteGroup(pos);
}
```

> [!TIP]
> Remember that the index starts at 0.
