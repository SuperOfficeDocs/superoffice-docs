---
title: Integer getItemIndex(Integer p\_group, String p\_itemId)
path: /EJScript/Classes/MainMenu/Member functions/Integer getItemIndex(Integer p_group, String p_itemId)
intellisense: 1
classref: 1
sortOrder: 505
keywords: getItemIndex(Integer,String)
---

# Integer getItemIndex(Integer group, String label)

Returns the position of a specific item in the group given its label (ID)

```crmscript
MainMenu menu = getMainMenu();
Integer pos = menu.getItemIndex(2,"secret company");
```

> [!TIP]
> Remember that the index starts at 0.
