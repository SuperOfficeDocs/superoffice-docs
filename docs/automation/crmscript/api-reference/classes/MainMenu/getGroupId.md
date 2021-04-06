---
uid: crmscript_ref_MainMenu_getGroupId_Integer_p_group
title: MainMenu.getGroupId(Integer p_group)
intellisense: MainMenu.getGroupId
sortOrder: 508
keywords: getGroupId(Integer)
so.topic: reference
---

# String getGroupId(Integer group)

Returns the label (ID) of a group in the main menu given its position. The IDs are unique strings.

```crmscript
MainMenu menu = getMainMenu();
String label = menu.getGroupId(4);
``
