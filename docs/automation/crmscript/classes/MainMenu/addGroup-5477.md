---
title: crmscript_ref_MainMenu_addGroup_String_label_String_image_Integer_position
description: MainMenu.addGroup(String label, String image, Integer position)
intellisense: MainMenu.addGroup
sortOrder: 511
keywords: addGroup(String,String,Integer)
so.topic: reference
---

# Void addGroup(String label, String image, Integer position)

A variant of `addGroup()` that lets you specify the exact position.

```crmscript
MainMenu menu = getMainMenu();
menu.addGroup("My label", "http://..../graphics/picture.png, 3");
```

> [!NOTE]
> This will shift the index of all subsequent groups. Thus, you should not make assumptions about which slot a group is in.
