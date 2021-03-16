---
title: Void deleteGroup(Integer index)
path: /EJScript/Classes/MainMenu/Member functions/Void deleteGroup(Integer index)
intellisense: 1
classref: 1
sortOrder: 518
keywords: deleteGroup(Integer)
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
