---
title: crmscript_ref_MainMenu_addGroup_String_label_String_image
description: MainMenu.addGroup(String label, String image)
intellisense: MainMenu.addGroup
sortOrder: 510
keywords: addGroup(String,String)
so.topic: reference
---

# Void addGroup(String label, String image)

Appends a group to the end of the main menu with the given label and image.

```crmscript
MainMenu menu = getMainMenu();
menu.addGroup("My label", "http://..../graphics/picture.png");
```

> [!NOTE]
> The image is specified by the URL to the actual file.
