---
title: Void addItem(String label, String url)
path: /EJScript/Classes/MainMenu/Member functions/Void addItem(String label, String url)
intellisense: 1
classref: 1
sortOrder: 513
keywords: addItem(String,String)
---

# Void addItem(String label, String url)

Appends an item to the last (bottom) group of the main menu.

```crmscript
MainMenu menu = getMainMenu();
menu.addItem("List equipment", getProgram(1) + "&action=listExtraTable&extraTable=y_equipment");
```

> [!NOTE]
> The image is specified by the URL to the actual file.
