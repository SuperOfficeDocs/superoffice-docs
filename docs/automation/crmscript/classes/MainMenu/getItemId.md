---
title: crmscript_ref_MainMenu_getItemId_Integer_p_groupId_Integer_p_itemId
description: MainMenu.getItemId(Integer p_groupId, Integer p_itemId)
intellisense: MainMenu.getItemId
sortOrder: 509
keywords: getItemId(Integer,Integer)
so.topic: reference
---

# String getItemId(Integer group, Integer pos)

Returns the label (ID) of an item in a group given its position.

```crmscript
MainMenu menu = getMainMenu();
String label = menu.getItemId(4,1);
```
