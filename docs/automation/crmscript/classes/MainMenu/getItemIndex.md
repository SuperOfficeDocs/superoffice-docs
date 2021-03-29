---
title: crmscript_ref_MainMenu_getItemIndex_Integer_p_group_String_p_itemId
description: MainMenu.getItemIndex(Integer p_group, String p_itemId)
intellisense: MainMenu.getItemIndex
sortOrder: 505
keywords: getItemIndex(Integer,String)
so.topic: reference
---

# Integer getItemIndex(Integer group, String label)

Returns the position of a specific item in the group given its label (ID)

```crmscript
MainMenu menu = getMainMenu();
Integer pos = menu.getItemIndex(2,"secret company");
```

> [!TIP]
> Remember that the index starts at 0.
