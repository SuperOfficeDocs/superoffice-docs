---
uid: crmscript_ref_MainMenu_addItem_String_label_String_url
title: MainMenu.addItem(String label, String url)
intellisense: MainMenu.addItem
sortOrder: 513
keywords: addItem(String,String)
so.topic: reference
---

# Void addItem(String label, String url)

Appends an item to the last (bottom) group of the main menu.

```crmscript
MainMenu menu = getMainMenu();
menu.addItem("List equipment", getProgram(1) + "&action=listExtraTable&extraTable=y_equipment");
```

> [!NOTE]
> The image is specified by the URL to the actual file.
