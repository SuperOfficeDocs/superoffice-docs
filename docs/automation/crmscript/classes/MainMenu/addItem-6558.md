---
title: Void addItem(String label, String url, Integer group, Integer position)
path: /EJScript/Classes/MainMenu/Member functions/Void addItem(String label, String url, Integer group, Integer position)
intellisense: 1
classref: 1
sortOrder: 514
keywords: addItem(String,String,Integer,Integer)
---

# Void addItem(String label, String url, Integer group, Integer position)

A variant of `addItem()` that lets you specify the exact position.

```crmscript
MainMenu menu = getMainMenu();
menu.addItem("New unit", getProgram(1) + "&action=editExtraTableEntry&extraTable=y_equipment", 1, 1);
```

> [!NOTE]
> This will shift the index of all subsequent items (if any). Thus, you should not make assumptions about which slot an item is in.
