---
uid: crmscript_ref_MainMenu_getGroupIndex_String
title: MainMenu.getGroupIndex(String)
intellisense: MainMenu.getGroupIndex
sortOrder: 504
keywords: getGroupIndex(String)
so.topic: reference
---

# Integer getGroupIndex(String)

Returns the position of a specific group in the main menu given its label (ID)

```crmscript
MainMenu menu = getMainMenu();
Integer pos = menu.getGroupIndex("my MITs");
```

> [!TIP]
> Remember that the index starts at 0.
